﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CSharp6NewFeatures.CustomStaticClass;

namespace CSharp6NewFeatures
{
    public partial class MainForm : Form
    {

        #region Fields

        Task _aSyncTask { get; set; }

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Event handling

        #region On Form Load

        //On Form Load, using the Using Static Syntax, directly call the Static Class's method
        private void MainForm_Load(object sender, EventArgs e)
        {
            ResultStringTxtBox.Text = GetAHelloMessage();
        }

        #endregion

        #region Action Button Click

        /// <summary>
        /// Generating a result string by using String interpolation (concatenating Strings #1 - #3)
        /// </summary>
        private void ActionBtn_Click(object sender, EventArgs e)
        {
            string firstString = String1TxtBox.Text;
            string secondString = String2TxtBox.Text;
            string thirdString = String3TxtBox.Text;

            try
            {
                //handling "erroneous" inputs
                if (firstString.Contains("XYZ") || secondString.Contains("XYZ") || thirdString.Contains("XYZ"))
                {
                    throw new Exception(Resource1.sXYZErrorMessage);
                }
                else if (firstString.Contains("ABC") || secondString.Contains("ABC") || thirdString.Contains("ABC"))
                {
                    throw new Exception(Resource1.sABCErrorMessage);
                }
                else if (firstString.Contains("W00T?") || secondString.Contains("W00T?") || thirdString.Contains("W00T?"))
                {
                    throw new Exception(Resource1.sW00TErrorMessage);
                }

                string resultString = $"{firstString} {secondString} {thirdString}";
                ResultStringTxtBox.Text = resultString;
            }
            catch (Exception ex) when (ex.Message.Equals(Resource1.sXYZErrorMessage) || ex.Message.Equals(Resource1.sABCErrorMessage))
            {
                ResultStringTxtBox.Text = Resource1.sXYZorABCInputDetected;
            }
            finally
            {
                //do something
            }
        }

        #endregion

        #region Async Operation Btn Click

        private void AsyncActionBtn_Click(object sender, EventArgs e)
        {
            if (_aSyncTask != null && _aSyncTask.Status == TaskStatus.Running)
            {
                return;
            }
            AsyncProgressLbl.Text = "Initializing";
            var progress = new Progress<int>(percent =>
            {
                if (percent != 100)
                {
                    AsyncProgressLbl.Text = percent + "%";
                } else
                {
                    AsyncProgressLbl.Text = "Completed";
                }
            });
            
            try
            {
                _aSyncTask = new Task(() => DoSomeProcessing(progress));
                _aSyncTask.Start();
            }
            catch (AggregateException)
            {
                AsyncProgressLbl.Text = "Exception in Task.";
            }
        }

        #endregion

        #endregion

        #region Private / Helper methods

        private void DoSomeProcessing(IProgress<int> progress)
        {
            for (int i = 0; i <= 100; ++i)
            {
                Thread.Sleep(500);
                if (progress != null)
                {
                    progress.Report(i);
                }
            }
        }

        #endregion

    }
}
