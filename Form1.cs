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

namespace ImageViewerProject
{
    public partial class Form1 : Form
    {
        //declaring fields for ImageViewer
        List<string> images = new List<string>(); 
        List<string> directories = new List<string>();
        //save index for currently selected image
        int selectedIndex;
        //if we should loop slideshow
        bool loop=false;
        
        public Form1()
        {
            InitializeComponent();
            //Tasks that should be executed when creating Form object
            //load startup.ini file
            LoadConfiguration();
            //repopulate lists to keep the latest data
            ListRefresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        //This method adds selected directories in the Directory listbox
        private void buttonAddDirectory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbdialog = new FolderBrowserDialog()) 
            {
                //using FBDialog object to select directories
                //adding selected path to the directories list
                if (fbdialog.ShowDialog() == DialogResult.OK)
                {
                    listBoxDirectories.Items.Add(fbdialog.SelectedPath);
                    directories.Add(fbdialog.SelectedPath);
                    ListRefresh();
                }
            }
        }

        //This button should delete the selected directory from Directory list
        private void buttonRemoveDirectory_Click(object sender, EventArgs e)
        {
            //removing directory at selected index
            if (listBoxDirectories.SelectedIndex != -1)
            {
                listBoxDirectories.Items.RemoveAt(listBoxDirectories.SelectedIndex);
            }
        }

        //refresh button calls the refresh method
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ListRefresh();   
        }

        //implementing functionality for the play button
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (images.Count != 0) 
            {
                //if timer is activated
                if (timer.Enabled)
                {
                    //stop the slideshow, reset the form
                    StopSlides();
                }
                else
                {
                    //if timer is not running yet
                    //change play button to stop
                    buttonPlay.Text = "Stop";
                    //disable buttons
                    buttonPrevious.Enabled = false;
                    buttonNext.Enabled = false;
                    buttonAddDirectory.Enabled = false;
                    buttonRemoveDirectory.Enabled = false;
                    buttonRefresh.Enabled = false;
                    //disable listboxes
                    listBoxDirectories.Enabled = false;
                    listBoxImages.Enabled = false;
                    //disable interval
                    textBoxInterval.Enabled = false;
                    //disable checkbox
                    checkBoxLoop.Enabled = false;
                    //start the countdown
                    timer.Start();
                }
            }
        }

        //adding functionality for the buttonPrevious
        //should change to the previous picture if it exists
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            //decrease the selected index field
            selectedIndex--;
            //selected index becomes the last index if it is less than 0
            if (selectedIndex < 0) selectedIndex = images.Count - 1;
            //update picture boxes onUI
            UpdatePictures();
        }

        //implementing functionality for the buttonNext
        //should change to the next picture if it exists
        private void buttonNext_Click(object sender, EventArgs e)
        {
            //increase the selected index
            selectedIndex++;
            //check if it has reached the end of images array
            if (selectedIndex >= images.Count) selectedIndex = 0;
            //update picture boxes on UI
            UpdatePictures();
        }

        //functionality for the interval textbox
        //determines how fast pictures change during the slideshow
        private void textBoxInterval_TextChanged(object sender, EventArgs e)
        {
            int interval;
            if (int.TryParse(textBoxInterval.Text, out interval))
            {
                //if value can be used as an interval
                //default backcolor
                textBoxInterval.BackColor = SystemColors.Window;
                //enable the user to play the slideshow
                buttonPlay.Enabled = true;
                //save the interval value in timer object
                timer.Interval = interval;
            }
            else 
            {
                //if value can`t be used as an interval
                //make interval textbox color red
                textBoxInterval.BackColor = Color.Red;
                //disable the play button
                buttonPlay.Enabled = false;
            }
        }
        
        //adding functionality for the loop checkbox
        private void checkBoxLoop_CheckedChanged(object sender, EventArgs e)
        {
            //if checkbox is checked, auto reset the timer
            loop = checkBoxLoop.Checked;
        }

        //image listbox event handler
        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            //save the selected index
            selectedIndex = listBoxImages.SelectedIndex;
            //update pictures on UI
            UpdatePictures();
        }

        //functinality for timer tick
        private void timer_Tick(object sender, EventArgs e)
        {
            //increase the selected index
            selectedIndex++;
            //if we reached the end of images
            if (selectedIndex >= images.Count)
            {
                //if we should loop the slideshow
                if (loop)
                {
                    //reset the index
                    selectedIndex = 0;
                }
                else
                {
                    //we have reached the end
                    selectedIndex = images.Count - 1;   
                    StopSlides();
                }
            }
            //update pictures on UI
            UpdatePictures();
        }
        

        //this method refreshes image and directory lists
        private void ListRefresh() 
        { 
            //get the lists again to refresh
            directories = FetchDirectories();
            images = FetchImages();
            //first the listboxes are emptied
            listBoxImages.Items.Clear();
            listBoxDirectories.Items.Clear();
            //update listbox images and listbox directories
            for (int i = 0; i < images.Count; i++)
            {
                //add images 
                listBoxImages.Items.Add(Path.GetFileName(images[i]));
            }
            //add directories
            foreach (string dir in directories) listBoxDirectories.Items.Add(dir);
            //if image list is empty
            if (images.Count == 0)
            {
                //change UI
                pictureBoxCurrent.Image = null;
                pictureBoxNext.Image = null;
                pictureBoxPrevious.Image = null;
            }
            else
            {
                //set index on the first image
                selectedIndex = 0;
                //update UI
                UpdatePictures();
            }
        }

        //this method fetches images which from directories
        private List<string> FetchImages() 
        { 
            List<string> images = new List<string>();
            foreach (string dir in directories) 
            {
                //get image files in each directory
                string[] jpgs = Directory.GetFiles(dir, "*.jpg");
                string[] pngs = Directory.GetFiles(dir, "*.png");
                images.AddRange(jpgs);
                images.AddRange(pngs);
            }
            return images;    
        }

        //this method fetches selected directories 
        private List<string> FetchDirectories() 
        {   
            List<string> dirs = new List<string>();
            //read every selected directory
            foreach (string dir in listBoxDirectories.Items) 
            { 
                //before adding a directory check if it exists
                if(Directory.Exists(dir))dirs.Add(dir);
            }
            return dirs;
        }

        //updates pictures on UI
        private void UpdatePictures() 
        {
            // If the selected index is in range
            if (selectedIndex >= 0 && selectedIndex < images.Count)
            {
                try
                {
                    // Load current image
                    pictureBoxCurrent.Image = Image.FromFile(images[selectedIndex]);
                }
                catch (Exception) 
                {
                    pictureBoxCurrent.Image = null;
                }
                try 
                {
                    // check if there is the previous image
                    pictureBoxPrevious.Image = selectedIndex > 0 ? Image.FromFile(images[selectedIndex - 1]) : null;
                }
                catch(Exception) 
                { 
                    pictureBoxPrevious.Image = null; 
                }
                try
                {
                    pictureBoxNext.Image = selectedIndex < images.Count - 1 ? Image.FromFile(images[selectedIndex + 1]) : null;
                }
                catch (Exception) { 
                    pictureBoxNext.Image = null; 
                }
            }
        }

        //this method stops the slideshow and resets the form
        private void StopSlides() 
        { 
            timer.Stop();
            //change playButton text
            buttonPlay.Text = "Play";
            //make listboxes Enabled
            listBoxDirectories.Enabled = true;
            listBoxImages.Enabled = true;
            //make interval textbox enabled
            textBoxInterval.Enabled = true;
            //make buttons enabled
            buttonPrevious.Enabled = true;
            buttonNext.Enabled = true;
            buttonAddDirectory.Enabled = true;
            buttonRemoveDirectory.Enabled = true;
            buttonRefresh.Enabled = true;
            //enable checkbox
            checkBoxLoop.Enabled = true;
        }

        //this method loads the default configurations
        private void LoadConfiguration() 
        {
            string startup_path = @"..\..\startup.ini";
            if (File.Exists(startup_path))
            {
                //read lines
                string[] lines = File.ReadAllLines(startup_path);
                foreach (string line in lines)
                {
                    //traverse over every line
                    //split it with equals symbol
                    string[] line_split = line.Split('=');
                    string fir_half = line_split[0];
                    string sec_half = line_split[1];
                    //add starup directory
                    if (fir_half == "StartupDirectory")
                    {
                        listBoxDirectories.Items.Add(sec_half);
                        directories.Add(sec_half);
                    }
                    else if (fir_half == "DefaultPictureSize")
                    {
                        //split the swcond value to get width and length
                        string[] width_length = sec_half.Split(';');
                        int width = int.Parse(width_length[0]);
                        int height = int.Parse(width_length[1]);
                        //set correct pic size
                        SetPicSize(width, height);
                    }

                }
            }
            else 
            {
                //if startup.ini doesn`t exist, create it
                using (StreamWriter sw = new StreamWriter(startup_path)) 
                {
                    sw.WriteLine(@"StartupDirectory=""");
                    sw.WriteLine("DefaultPictureSize=800;400");
                    sw.Close();
                }
            }
        }

        //this method recieves 2 parameters: width and height
        //then it sets the correct size to pictures according the rules
        private void SetPicSize(int width, int height)
        {
            if (width != 800 && height != 400) 
            {
                // If the width or height is greater than 1000, set it to 1000
                if (width > 1000) width = 1000;
                if (height > 1000) height = 1000;
                // Set the size of the pictureBoxes
                pictureBoxCurrent.Size = new Size(width, height);
                pictureBoxPrevious.Size = new Size(width / 4, height / 4);
                pictureBoxNext.Size = new Size(width / 4, height / 4);
            }
        }

    }
}
