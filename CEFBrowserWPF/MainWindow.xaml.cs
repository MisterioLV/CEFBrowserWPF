using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CEFBrowserWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class GFG
        {

            // Stores the current 
            // visiting page
            static String current_state_url = "";

            // Stores url when pressed forward
            static Stack<String>
                   forward_stack = new Stack<String>();

            // Stores url when pressed backward
            static Stack<String>
                   backward_stack = new Stack<String>();

            // Function for when visit a url
            static void visit_new_url(String url)
            {
                // If current URL is empty
                if (current_state_url != "")
                {
                    // Push into backward_stack
                    backward_stack.Push(
                             current_state_url);
                }

                // Set curr_state_url to url
                current_state_url = url;
            }

            // Function to handle state 
            // when the forward button 
            // is pressed
            static void forward()
            {
                // If current url is the last url
                if (forward_stack.Count == 0 ||
                    current_state_url ==
                    forward_stack.Peek())
                {
                    Console.Write("Not Available\n");
                    return;
                }

                // Otherwise
                else
                {
                    // Push current state to the
                    // backward steck
                    backward_stack.Push(
                             current_state_url);

                    // Set current state to top
                    // of forward stack
                    current_state_url =
                            forward_stack.Peek();

                    // Remove from forward 
                    // stack
                    forward_stack.Pop();
                }
            }

            // Function to handle state
            // when the backward button 
            // is pressed
            static void backward()
            {
                // If current url is the 
                // last url
                if (backward_stack.Count != 0 ||
                    current_state_url ==
                    backward_stack.Peek())
                {
                    Console.Write("Not Available\n");
                    return;
                }

                // Otherwise
                else
                {
                    // Push current url to the
                    // forward stack
                    forward_stack.Push(
                            current_state_url);

                    // Set current url to top
                    // of backward stack
                    current_state_url =
                            backward_stack.Peek();

                    // Pop it from backward 
                    // stack
                    backward_stack.Pop();
                }
            }

            // Function that performs the 
            // process of pressing forward 
            // and backward button in a
            // Browser
            static void simulatorFunction()
            {
                // Current URL
                String url = "ajay.com";

                // Visit the current URL
                visit_new_url(url);

                // Print the current URL
                Console.Write("Current URL is: " +
                              current_state_url +
                              " \n");

                // New current URL
                url = "abc.com";

                // Visit the current URL
                visit_new_url(url);

                // Print the current URL
                Console.Write("Current URL is: " +
                              current_state_url +
                              " \n");

                // Pressed backward button
                backward();

                // Print the current URL
                Console.Write("Current URL after pressing" +
                              " Backward button is: " +
                              current_state_url + " \n");

                // Pressed forward button
                forward();

                // Print the current URL
                Console.Write("Current URL after pressing" +
                              " Forward button is: " +
                              current_state_url + " \n");

                // New current URL
                url = "nikhil.com";

                // Visit the current URL
                visit_new_url(url);

                // Print the current URL
                Console.Write("Current URL is: " +
                              current_state_url +
                              " \n");

                // Pressed forward button
                forward();

                // Print the current URL
                Console.Write("Current URL after pressing" +
                              " Forward button is: " +
                              current_state_url + " \n");
                // Pressed backward button
                backward();

                // Print the current URL
                Console.Write("Current URL after pressing" +
                              " Backward button is: " +
                              current_state_url + " \n");
            }

            // Driver Code
            public static void Main(String[] args)
            {
                // Function to simulate process of
                // pressing forward & backward button
                simulatorFunction();
            }
        }

        // This code is contributed by shikhasingrajput

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            Browser.Load(AddressBar.Text);
        }

        
        // Ignore this one
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            Browser.Load("http://www.google.com");
        }

        
        // Working on these two
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ICommand backCommand = Browser.BackCommand;
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            ICommand forwardCommand = Browser.ForwardCommand;
        }
    }
}
