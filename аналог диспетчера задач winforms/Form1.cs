using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace аналог_диспетчера_задач_winforms
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Windows.Forms;

    
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
                LoadProcesses();
            }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadProcesses()
        {
            var processes = Process.GetProcesses()
                .Select(p =>
                {
                    try
                    {
                        return new
                        {
                            Name = p.ProcessName,
                            ID = p.Id,
                            Memory = p.WorkingSet64 / 1024 / 1024 + " MB",
                            StartTime = p.StartTime.ToString()
                        };
                    }
                    catch (Win32Exception ex)
                    {
                        return new
                        {
                            Name = "Access denied",
                            ID = p.Id,
                            Memory = "",
                            StartTime = ""
                        };
                    }
                })
                .ToList();

            dataGridViewProcesses.DataSource = processes;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
            {
                LoadProcesses();
            }

            private void buttonTerminate_Click(object sender, EventArgs e)
            {
                if (dataGridViewProcesses.SelectedRows.Count > 0)
                {
                    int processId = (int)dataGridViewProcesses.SelectedRows[0].Cells["ID"].Value;
                    try
                    {
                        Process.GetProcessById(processId).Kill();
                        MessageBox.Show("Процесс успешно завершен.");
                        LoadProcesses();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка завершения процесса: " + ex.Message);
                    }
                }
            }

            private void buttonFilter_Click(object sender, EventArgs e)
            {
                string filter = textBoxFilter.Text.ToLower();
                var processes = Process.GetProcesses()
                    .Where(p => p.ProcessName.ToLower().Contains(filter))
                    .Select(p => new
                    {
                        Name = p.ProcessName,
                        ID = p.Id,
                        Memory = p.WorkingSet64 / 1024 / 1024 + " MB",
                        StartTime = p.StartTime.ToString()
                    })
                    .ToList();

                dataGridViewProcesses.DataSource = processes;
            }

        private void buttonUserProcesses_Click(object sender, EventArgs e)
        {
            var currentUserName = Environment.UserName;
            var processes = Process.GetProcesses()
                .Where(p =>
                {
                    try
                    {
                        return p.StartInfo.UserName == currentUserName;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                })
                .Select(p => new
                {
                    Name = p.ProcessName,
                    ID = p.Id,
                    Memory = p.WorkingSet64 / 1024 / 1024 + " MB",
                    StartTime = p.StartTime.ToString()
                })
                .ToList();

            dataGridViewProcesses.DataSource = processes;
        }
    }


    }
    

