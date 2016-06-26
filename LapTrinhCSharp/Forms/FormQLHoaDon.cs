using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using EzLife;

namespace LapTrinhCSharp.Forms
{
    public partial class FormQLHoaDon : Form
    {
        public FormQLHoaDon()
        {
            InitializeComponent();
        }

        private void QLHopDong_Load(object sender, EventArgs e)
        {
            rdTatca.Checked = true;
            LoadComboBoxes();
            LoadGridView();
        }

        private void LoadGridView()
        {
            Grid.AutoGenerateColumns = false;
            using (var db = new DbKTX())
            {
                IEnumerable<HoaDon> query = db.HoaDon.Include("Phong");
                if (rdChuaTT.Checked)
                {
                    query = query.Where(hd => !hd.DaThanhToan);
                }
                else if (rdDaTT.Checked)
                {
                    query = query.Where(hd => hd.DaThanhToan);
                }
                if (chkPhong.Checked)
                {
                    var phong = Convert.ToInt32(cmbFPhong.SelectedValue);
                    query = query.Where(x => x.MaPhong == phong);
                }
                Grid.DataSource = query.Select(x=> new
                {
                    ID = x.ID,
                    Phong = x.Phong.Ten,
                    Thang = x.Thang,
                    Nam = x.Nam,
                    TienPhong = x.TienPhong,
                    TienDien = x.TienDien,
                    TienNuoc = x.TienNuoc,
                    PhuPhi = x.PhuPhi,
                    TongTien = x.TienPhong + x.TienDien + x.TienNuoc + x.PhuPhi,
                    DaThanhToan = x.DaThanhToan
                }).ToList();
            }
        }


        private void LoadComboBoxes()
        {
            using (var db = new DbKTX())
            {
                cmbPhong.DisplayMember = cmbFPhong.DisplayMember = "Ten";
                cmbPhong.ValueMember = cmbFPhong.ValueMember = "ID";
                cmbPhong.DataSource = db.Phong.Include("Nha").Select(x => new {ID = x.ID, Ten = x.Nha.Ten + " : " + x.Ten}).ToList();
                cmbFPhong.DataSource = db.Phong.Include("Nha").Select(x => new {ID = x.ID, Ten = x.Nha.Ten + " : " + x.Ten}).ToList();
            }

            cmbThang.Items.AddRange(Enumerable.Range(1, 12).Select(x=>x.ToString()).ToArray());
            cmbThang.SelectedItem = DateTime.Today.Month.ToString();
            cmbNam.Items.AddRange(Enumerable.Range(2015, 18).Select(x => x.ToString()).ToArray());
            cmbNam.SelectedItem = DateTime.Today.Year.ToString();
        }

        private void LoadFormData()
        {
            if (Grid.SelectedRows.Count == 0)
                return;
            int id = (int)Grid.SelectedRows[0].Cells[0].Value;
            using (var db = new DbKTX())
            {
                var hd = db.HoaDon.First(x => x.ID == id);
                cmbPhong.SelectedValue = hd.MaPhong;
                cmbNam.SelectedItem = hd.Nam.ToString();
                cmbThang.SelectedItem = hd.Thang.ToString();
                checkTT.Checked = hd.DaThanhToan;

                txtPhuphi.Text = hd.PhuPhi.ToString();
                txtTiendien.Text = hd.TienDien.ToString();
                txtTiennuoc.Text = hd.TienNuoc.ToString();
                txtTienphong.Text = hd.TienPhong.ToString();
            }
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            LoadFormData();
        }

        private void FillData(HoaDon hd)
        {
            hd.MaPhong = (int) cmbPhong.SelectedValue;
            hd.Thang = Convert.ToInt32(cmbThang.SelectedItem);
            hd.Nam = Convert.ToInt32(cmbNam.SelectedItem);
            hd.TienDien = Convert.ToDouble(txtTiendien.Text);
            hd.TienNuoc = Convert.ToDouble(txtTiennuoc.Text);
            hd.TienPhong = Convert.ToDouble(txtTienphong.Text);
            hd.PhuPhi = Convert.ToDouble(txtPhuphi.Text);
            hd.DaThanhToan = checkTT.Checked;
        }
        private HoaDon FormData
        {
            get
            {
              return new HoaDon
              {
                  MaPhong = (int)cmbPhong.SelectedValue,
                  Thang = Convert.ToInt32(cmbThang.SelectedItem),
                  Nam = Convert.ToInt32(cmbNam.SelectedItem),
                  TienDien = Convert.ToDouble(txtTiendien.Text),
                  TienNuoc = Convert.ToDouble(txtTiennuoc.Text),
                  TienPhong = Convert.ToDouble(txtTienphong.Text),
                  PhuPhi = Convert.ToDouble(txtPhuphi.Text),
                  DaThanhToan = checkTT.Checked
              };
            }
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var db = new DbKTX())
            {
                db.HoaDon.Add(FormData);
                db.SaveChanges();
            }
            LoadGridView();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (Grid.SelectedRows.Count == 0)
                return;
            var id = (int)Grid.SelectedRows[0].Cells[0].Value;
            using (var db = new DbKTX())
            {
                var hd = db.HoaDon.First(x => x.ID == id);
                FillData(hd);
                db.SaveChanges();
            }
            LoadGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Grid.SelectedRows.Count == 0)
                return;
            using (var db = new DbKTX())
            {
                var listIds = (from object r in Grid.SelectedRows select (int)((DataGridViewRow)r).Cells[0].Value).ToList();
                var toRemove = db.HoaDon.Where(x => listIds.Contains(x.ID));
                db.HoaDon.RemoveRange(toRemove);
                db.SaveChanges();
            }
            LoadGridView();
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            (new FormReportHoaDon()).ShowDialog();
        }

        private void radChecked(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            using (var db = new DbKTX())
            {
                foreach (var phong in db.Phong)
                {
                    for (var thang=1;thang <= 12;thang++)
                    db.HoaDon.Add(new HoaDon
                    {
                        MaPhong = phong.ID,
                        ChiTiet = "Chi tiết!",
                        DaThanhToan = rand.Next()%2==0,
                        Thang = thang,
                        Nam = DateTime.Today.Year,
                        TienPhong = Math.Round(1000000 * rand.NextDouble()),
                        TienDien = Math.Round(200000 * rand.NextDouble()),
                        TienNuoc = Math.Round(100000 * rand.NextDouble()),
                        PhuPhi = Math.Round(50000 * rand.NextDouble())
                    });
                }
                db.SaveChanges();
            }
        }

        private void cmbFPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkPhong.Checked)
                LoadGridView();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (Grid.SelectedRows.Count == 0)
                return;
            var id = (int)Grid.SelectedRows[0].Cells[0].Value;
            using (var db = new DbKTX())
            {
                var hd = db.HoaDon.First(o => o.ID == id);
                var doc = Novacode.DocX.Load("hoadon.docx");
                doc.ReplaceText("{hoadon}", hd.ID.ToString("D8"));
                doc.ReplaceText("{room}", hd.Phong.Nha.Ten + " " + hd.Phong.Ten);
                doc.ReplaceText("{ngay}", DateTime.Today.ToString("dd/MM/yyyy"));

                doc.ReplaceText("{tienphong}", hd.TienPhong.ToString("n0"));
                doc.ReplaceText("{tiennuoc}", hd.TienNuoc.ToString("n0"));
                doc.ReplaceText("{tiendien}", hd.TienDien.ToString("n0"));
                doc.ReplaceText("{phuphi}", hd.PhuPhi.ToString("n0"));
                doc.ReplaceText("{tong}", (hd.TienPhong + hd.TienNuoc + hd.PhuPhi).ToString("n0"));


                doc.SaveAs("tmp.docx");
                var info = new ProcessStartInfo("tmp.docx");
                info.Verb = "Print";
                // info.CreateNoWindow = true;
                // info.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(info);
            }
        }
    }
}
