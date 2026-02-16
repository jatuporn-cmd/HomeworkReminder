using System;
using System.Windows.Forms;

namespace HomeworkReminder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // คำสั่งนี้จะไปเรียกโค้ดใน Form1.Designer.cs ให้ทำงาน
            InitializeComponent();

            // ตั้งค่าเริ่มต้นให้ ComboBox เลือกตัวแรกสุด
            if (cboSubject.Items.Count > 0) cboSubject.SelectedIndex = 0;
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
        }

        // ฟังก์ชันเมื่อกดปุ่ม Add (เชื่อมกับปุ่มใน Designer แล้ว)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. รับค่า
            string hwId = txtHomeworkID.Text.Trim();
            string hwTitle = txtHomeworkTitle.Text.Trim();
            string subject = cboSubject.Text;
            string status = cboStatus.Text;

            // 2. Data Validation
            if (string.IsNullOrEmpty(hwId) || string.IsNullOrEmpty(hwTitle))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน!\n(ห้ามเว้นว่าง รหัสการบ้าน และ ชื่อเรื่อง)",
                                "แจ้งเตือน",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 3. แสดงผล (MessageBox)
            string message = "บันทึกข้อมูลสำเร็จ!\n\n" +
                             "รหัสการบ้าน: " + hwId + "\n" +
                             "ชื่อเรื่อง: " + hwTitle + "\n" +
                             "รายวิชา: " + subject + "\n" +
                             "สถานะ: " + status;

            MessageBox.Show(message,
                            "รายละเอียดการบ้าน",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // 4. ล้างหน้าจอ
            txtHomeworkID.Clear();
            txtHomeworkTitle.Clear();
            cboSubject.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            txtHomeworkID.Focus();
        }
    }
}