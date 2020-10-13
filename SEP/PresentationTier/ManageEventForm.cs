﻿using DataTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class ManageEventForm : Form
    {
        private readonly Form mainForm;
        public ManageEventForm(Form mainForm, Event ev)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            this.eventRecordText.Text = ev.RecordNr;
            this.eventRecordText.Enabled = false;
            this.eventClientText.Text = ev.Client.FirstName + " " + ev.Client.LastName;
            this.eventClientText.Enabled = false;
            this.eventTypeText.Text = ev.EventType;
            this.eventTypeText.Enabled = false;
            this.descriptionText.Text = ev.Description;
            this.descriptionText.Enabled = false;
            this.attendeesText.Text = ev.Attendees.ToString();
            this.attendeesText.Enabled = false;
            this.budgetText.Text = ev.Budget.ToString();
            this.budgetText.Enabled = false;
            this.fromDatePicker.Value = ev.From;
            this.fromDatePicker.Enabled = false;
            this.toDatePicker.Value = ev.To;
            this.toDatePicker.Enabled = false;


            this.decorationsText.Text = ev.Decorations;
            this.foodText.Text = ev.FoodAndDrinks;
            this.filmingText.Text = ev.Filming;
            this.musicText.Text = ev.Music;
            this.postersText.Text = ev.Posters;
            this.computerText.Text = ev.ComputerRelatedIssues;
            this.otherText.Text = ev.OtherNeeds;
        }

    }
}