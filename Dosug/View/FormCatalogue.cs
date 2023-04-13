using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dosug.Classes;
using Dosug.Entity;

namespace Dosug
{
    public partial class FormCatalogue : Form
    {
        private List<Event> events = new List<Event>();
        public FormCatalogue()
        {
            InitializeComponent();
            try
            {
                Helper.ModelDB = new ModelDB();
                Helper.ModelDB.Database.Connection.Open();
                MessageBox.Show("Успешное подключение к БД", "Подключение к БД", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться к БД", "Подключение к БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCatalogue_Load(object sender, EventArgs e)
        {
            LoadEvents();
            foreach(Event someEvent in events)
            {
                int id = DataGridViewEvents.Rows.Add();
                DataGridViewEvents.Rows[id].Height = 80;
                var direction = Helper.ModelDB.Direction.Where(direct => direct.DirectionId == someEvent.EventDirection).First();
                if (someEvent.EventPhoto is null)
                    DataGridViewEvents.Rows[id].Cells[0].Value = Properties.Resources.picture;
                else
                    DataGridViewEvents.Rows[id].Cells[0].Value = someEvent.EventPhoto;
                DataGridViewEvents.Rows[id].Cells[1].Value = "Название: " + someEvent.EventName + "\n" +
                    "Направление: " + direction.DirectionName + "\nДата: " + someEvent.EventDate + "\nВремя: " + someEvent.EventTime +
                    "\nПродолжительность: " + someEvent.EventDuration + " мин.";
            }
            
        }

        private void LoadEvents()
        {
            events = Helper.ModelDB.Event.ToList();
        }

        private void FormCatalogue_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Helper.ModelDB.Database.Connection.Close();
                MessageBox.Show("Успешное отключение от БД", "Отключение от БД", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Не удалось отключиться от БД", "Отключение от БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
