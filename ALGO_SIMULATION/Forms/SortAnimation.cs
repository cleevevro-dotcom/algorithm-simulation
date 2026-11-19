using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace ALGO_SIMULATION.Forms
{
    public partial class SortAnimation : Form
    {
        SortAnimation form;
        int[] num;
        string SortType;
        System.Windows.Forms.Label[] labels;
        int i = 0; // Outer loop index
        int j = 0; // Inner loop index
        bool whenStop = false;
        bool AnimationTiming = false;

        // Bubble Sort
        int tempValue; // Temporary variable for swapping
        bool isRunning = true;

        // Selection Sort
        int minIndex; // Index of the smallest element
        bool isAnimating = false; // Tracks if an animation is in progress
        int defaultDistance1;
        int defaultDistance2;

        //insertion
        int A;
        int Key; // Inner loop index
        bool anotherAnimation = false;
        public SortAnimation(int[] num, int lenght, string sortType)
        {
            labels = new Label[12];
            this.num = num;
            this.num = new int[lenght];
            SortType = sortType;
            Array.Copy(num, this.num, lenght);
            InitializeComponent();
            RestartAnimation.Enabled = false;

            labels[0] = label1;
            labels[1] = label2;
            labels[2] = label3;
            labels[3] = label4;
            labels[4] = label5;
            labels[5] = label6;
            labels[6] = label7;
            labels[7] = label8;
            labels[8] = label9;
            labels[9] = label10;
            labels[10] = label11;
            labels[11] = label12;
            placeValue();
        }

        void placeValue()
        {
            for (int i = 0; i < num.Length; i++)
            {
                this.labels[i].Text = "" + num[i];
            }
            for (int i = num.Length; i < labels.Length; i++)
            {
                labels[i].Text = string.Empty;
            }
        }

        private void StartAnimate_Click(object sender, EventArgs e)
        {
            StartAnimate.Enabled = false;
            RestartAnimation.Enabled = true;
            switch (SortType)
            {
                case "Bsort":
                    i = 0;
                    j = 0;
                    StartBubbleSortAnimation();
                    break;
                case "Ssort":
                    i = 0;
                    StartSelectionSortAnimation();
                    break;
                case "Isort":
                    i = 1;
                    StartInsertionSortAnimation();
                    break;
            }
        }
        void StartInsertionSortAnimation()
        {
            if (i < num.Length)
            {
                Key = num[i];
                j = i - 1;
                anotherAnimation = false; // Reset flag for new animation step
                isAnimating = true;       // Start animation
                Animation.Start();        // Begin the animation tick
            }
            else
            {
                Animation.Stop();
                MessageBox.Show("Insertion Sort Complete!");
                StartAnimate.Enabled = false;
                RestartAnimation.Enabled = false;
            }
        }
        void StartSelectionSortAnimation()
        {
            if (i < num.Length - 1)
            {
                minIndex = i; // Assume the current index is the smallest

                // Find the smallest element in the remaining array
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[j] < num[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // If the smallest element is not already in the correct position, animate the swap
                if (minIndex != i)
                {
                    Animation.Start(); // Start animation for swapping
                }
                else
                {
                    // Move to the next outer loop iteration
                    i++;
                    StartSelectionSortAnimation();
                }
            }
            else
            {
                MessageBox.Show("Sorting Complete!", "Selection Sort");
                StartAnimate.Enabled = false;
                RestartAnimation.Enabled = false;
            }
        }
        void StartBubbleSortAnimation()
        {
            if (i < num.Length - 1)
            {
                if (j < num.Length - 1 - i)
                {
                    if (num[j] > num[j + 1])
                    {
                        // Set up animation
                        Animation.Start();
                        return; // Pause sorting until animation completes
                    }
                    j++;
                    StartBubbleSortAnimation(); // Continue inner loop
                }
                else
                {
                    j = 0; // Reset inner loop index
                    i++; // Move to the next outer loop iterationxdeder43
                    StartBubbleSortAnimation(); // Continue outer loop
                }
            }
            else
            {
                MessageBox.Show("Sorting Complete!", "Bubble Sort");
                StartAnimate.Enabled = false;
                RestartAnimation.Enabled = false;
            }
        }
        private void AnimationSort(object sender, EventArgs e)
        {
            AnimationTiming = false;
            if (SortType == "Ssort")
            {
                Label label1 = labels[i];
                Label label2 = labels[minIndex];
                if (!isAnimating)
                {
                    defaultDistance1 = label1.Location.X;
                    defaultDistance2 = label2.Location.X;
                    isAnimating = true;
                }

                // Animate swapping
                if (label1.Top > label2.Top - 50 && isRunning)
                {
                    label1.Top -= 2;
                    label2.Top += 2;
                }
                else if (defaultDistance1 < label2.Left)
                {
                    label1.Left += 2; // Move label1 right
                    label2.Left -= 2; // Move label2 left
                }
                else if (label1.Top != label2.Top)// Ensure labels are aligned vertically
                {
                    isRunning = false;
                    label1.Top = Ypoint.Top;
                    label2.Top = Ypoint.Top;
                    label1.Top = label2.Top;
                    AnimationTiming = true;
                    if (whenStop && AnimationTiming)
                    {
                        Animation.Stop();
                        StartAnimate.Enabled = true;
                        whenStop = false;
                        RestartAnimation.Text = "Stop";
                    }
                }
                else
                {

                    Animation.Stop();
                    isAnimating = false;
                    isRunning = true;

                    // Swap the labels in the array
                    Label tempLabel = labels[i];
                    labels[i] = labels[minIndex];
                    labels[minIndex] = tempLabel;

                    // Swap the numbers in the array
                    int tempValue = num[i];
                    num[i] = num[minIndex];
                    num[minIndex] = tempValue;

                    // Move to the next outer loop iteration
                    i++;
                    StartSelectionSortAnimation();
                }
            }
            else if (SortType == "Bsort")
            {
                Label label1 = labels[j];
                Label label2 = labels[j + 1];
                if (!isAnimating)
                {
                    defaultDistance1 = label1.Location.X;
                    defaultDistance2 = label2.Location.X;
                    isAnimating = true;
                }
                // Move labels vertically up and down
                if (label1.Top > label2.Top - 50 && isRunning)
                {
                    label1.Top -= 2;
                    label2.Top += 2;
                }
                else if (defaultDistance1 < label2.Left)
                {
                    label1.Left += 2;
                    label2.Left -= 2;
                }
                else if (label1.Top != label2.Top)// Ensure labels are aligned vertically
                {
                    isRunning = false;
                    label1.Top = label2.Top;
                    label1.Top = Ypoint.Top;
                    label2.Top = Ypoint.Top;
                    AnimationTiming = true;
                    if (whenStop && AnimationTiming)
                    {
                        Animation.Stop();
                        StartAnimate.Enabled = true;
                        whenStop = false;
                        RestartAnimation.Text = "Stop";
                    }
                }
                else
                {
                    // Animation complete, swap label positions in array
                    Animation.Stop();
                    isRunning = true;
                    isAnimating = false;

                    // Swap labels in the array
                    Label tempLabel = labels[j];
                    labels[j] = labels[j + 1];
                    labels[j + 1] = tempLabel;

                    // Swap the numbers in the array
                    tempValue = num[j];
                    num[j] = num[j + 1];
                    num[j + 1] = tempValue;

                    // Continue sorting after animation
                    j++;

                    StartBubbleSortAnimation();
                }
            }
            if (SortType == "Isort" && isAnimating)
            {
                Label label1 = labels[j];     // Current label being compared
                Label label2 = labels[j + 1]; // Target position for insertion
                if (!anotherAnimation) // First step: Move Label 2 up
                {
                    defaultDistance1 = label1.Left;
                    defaultDistance2 = label2.Left;
                    if (label2.Top > label1.Top - 50 && num[j] > num[j + 1]) // Move Label 2 upward
                    {
                        label2.Top -= 2;
                    }
                    else
                    {
                        anotherAnimation = true; // Move to the next animation step
                    }
                }
                else if (num[j] > Key) // Second step: If Label 2 is greater, swap positions
                {
                    if (label2.Left > defaultDistance1) // Move Label 2 left
                    {
                        label2.Left -= 2;
                    }
                    else if (label1.Left < defaultDistance2) // Move Label 1 right to Label 2's original position
                    {
                        label1.Left += 2;
                    }
                    else if (label2.Top != Ypoint.Top) // Move Label 2 down to align with Label 1
                    {
                        label2.Top = Ypoint.Top;
                        AnimationTiming = true;
                        if (whenStop && AnimationTiming)
                        {
                            Animation.Stop();
                            StartAnimate.Enabled = true;
                            whenStop = false;
                            RestartAnimation.Text = "Stop";
                        }
                    }
                    else // Swap complete
                    {
                        // Stop animation and perform the logical swap
                        Animation.Stop();
                        anotherAnimation = false;

                        // Swap the labels in the array
                        Label tempLabel = labels[j + 1];
                        labels[j + 1] = labels[j];
                        labels[j] = tempLabel;

                        // Swap the numbers in the array
                        num[j + 1] = num[j];
                        num[j] = Key;

                        // Continue insertion sort logic
                        j--;

                        if (j < 0 || num[j] <= Key) // No more swaps needed
                        {
                            i++;
                            StartInsertionSortAnimation(); // Proceed to the next element
                        }
                        else
                        {
                            Animation.Start(); // Continue with the next comparison
                        }
                    }
                }
                else // If no swap needed, move to the next iteration
                {
                    Animation.Stop();
                    isAnimating = false;
                    i++;
                    StartInsertionSortAnimation();
                }
            }
        }

        private void RestartAnimation_Click(object sender, EventArgs e)
        {
            if (!whenStop)
            {
                whenStop = true;
                RestartAnimation.Text = "Waiting";
                RestartAnimation.Enabled = false;
            }
            else
            {
                whenStop = false;
            }
        }

        private void SortAnimation_Load(object sender, EventArgs e)
        {

        }
    }
}
