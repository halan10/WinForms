using MyWinForms.Data;
using System.Drawing.Imaging;

namespace MyWinForms
{
    public partial class MainForm : Form
    {
        private readonly AppEFContext _context = new AppEFContext();

        private int currentPage = 1;//поточна сторінка, де ми знаходимося
        private int pageSize = 5;  //к-ть записів, які ми показуємо
        private int totalPages = 0;//к-ть сторінок, які можна відображати
       
        public MainForm()
        {
            InitializeComponent();
            LoadList();
           
        }
        private void LoadList()
        {
            dgvUsers.Rows.Clear();
           
            var query = _context.Users.AsQueryable();//робимо sql запит до БД
            var users = query
                 .Skip((currentPage - 1) * pageSize) //к-ть запитыв , яку хочемо пропкустити
                 .Take(pageSize)//к-ть записыв, якы ми беремо ыз БД
                 .ToList();//Отримуэмо записи ыз БД



            foreach (var user in users)
            {
                object[] row = { user.Id, Image.FromFile(Path.Combine("images", user.Photo)), user.Name, user.Email, user.Phone };
                dgvUsers.Rows.Add(row);
            }
            int count = query.Count();
            totalPages = (int)Math.Ceiling(count / (double)pageSize);
            lblPAgeNumber.Text = String.Format("Page {0}/{1}", currentPage, totalPages);
            btnNext.Enabled = currentPage == totalPages ? false : true;
            btnPrev.Enabled = currentPage == 1 ? false : true;
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserForm dlg = new AddUserForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string dir = "images";//створення папки для збереження картинок
                if (!Directory.Exists(dir))//перевірка на наявність папки
                    Directory.CreateDirectory(dir);//якщо немає, створити нову

                Bitmap bitmap = new Bitmap(dlg.ImagePhoto);
                string imageName = Path.GetRandomFileName() + ".jpg";
                bitmap.Save(Path.Combine(dir, imageName), ImageFormat.Jpeg);
                AppUser user = new AppUser()
                {
                    Name = dlg.Pib,
                    Email = dlg.Email,
                    Phone = dlg.Phone,
                    Photo = imageName
                };
                _context.Users.Add(user);
                _context.SaveChanges();
                LoadList();
                //object[] row = { 1,Image.FromFile(dlg.ImagePhoto), dlg.Pib,dlg.Email,dlg.Phone};
                //dgvUsers.Rows.Add(row);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage !=  totalPages)
            {
                currentPage++;
                LoadList();
                lblPAgeNumber.Text = String.Format("Page {0}/{1}", currentPage, totalPages);
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            currentPage--;
            LoadList();
            lblPAgeNumber.Text = String.Format("Page {0}/{1}", currentPage, totalPages);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectRow = dgvUsers.GetCellCount(DataGridViewElementStates.Selected);
            if (selectRow > 0)
            {
                if (dgvUsers.AreAllCellsSelected(true))
                {
                MessageBox.Show("All cell are selected");
                }


            else
                {
                    if (selectRow > 1)
                    {
                        MessageBox.Show("Оберіть один рядок");
                        return;
                    }
                    var index = dgvUsers.SelectedCells[0].RowIndex;
                    int id = (int)dgvUsers.Rows[index].Cells[0].Value;
                    var user = _context.Users.SingleOrDefault(x => x.Id == id);
                    if (user != null)
                    {
                        string userImages = Path.Combine("images", user.Photo); 
                        EditUserForm dlg = new EditUserForm();
                        dlg.Pib = user.Name;
                        dlg.ImagePhoto = userImages;
                        dlg.Email = user.Email;
                        dlg.Phone = user.Phone;
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            if (dlg.ImagePhoto!= userImages)//заміняємо старе фото
                            {
                            Bitmap bitmap = new Bitmap(dlg.ImagePhoto);
                                string imageName = Path.GetRandomFileName() + ".jpg";
                                bitmap.Save (Path.Combine("images", imageName) , ImageFormat.Jpeg);
                                user.Photo = imageName;
                            }
                            user.Name = dlg.Pib;
                            user.Email = dlg.Email;
                            user.Phone = dlg.Phone;
                            _context.SaveChanges();
                            LoadList();
                        }
                    }
                   // MessageBox.Show("id = " + id);

                }
            }
            else
            {
                MessageBox.Show("Оберіть рядок, який треба змінити");
            }
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                DeleteUserForm dlg = new DeleteUserForm();
                var users = _context.Users.ToList();

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvUsers.SelectedRows)
                    {
                        dgvUsers.Rows.Remove(row);

                    }
                    _context.UpdateRange(users);
                    _context.SaveChanges();
                }

            }
        }
    }
    
}
