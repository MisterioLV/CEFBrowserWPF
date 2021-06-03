using System;
using System.Collections.Generic;

namespace CEFBrowserWPF
{
    public partial class GFG
    {
        string IntToString(int i)
        {
            return i.ToString();
        }

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
            if (current_state_url != "")
            {
                backward_stack.Push(current_state_url);                      
            }

            // Set curr_state_url to url
            current_state_url = url;
        }
        static void forward()
        {
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
                backward_stack.Push(current_state_url);

                current_state_url = forward_stack.Peek();
 
                forward_stack.Pop();
            }
        }
        static void backward()
        {
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
                forward_stack.Push(
                        current_state_url);

                current_state_url =
                        backward_stack.Peek();

                backward_stack.Pop();
            }
        }
        // Driver Code
        public static void Main(string[] args)
        {

            
        }
        static void SimulatorFunction()
        {
            // Current URL
            string url = "google.com";

            // Visit the current URL
            visit_new_url(url);

            // Print the current URL
            Console.Write("Current URL is: " +
                          current_state_url +
                          " \n");

            // New current URL
            url = "Youtube.com";

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
            Console.Write("Current URL after pressing" + " Forward button is: " + current_state_url + " \n");
                                                   
            // New current URL
            url = "nikhil.com";

            // Visit the current URL
            visit_new_url(url);

            // Print the current URL
            Console.Write("Current URL is: " + current_state_url + " \n");
                                                    
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
    }
}
