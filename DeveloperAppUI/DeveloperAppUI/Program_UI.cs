using DeveloperApp.POCOs;
using DeveloperApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperAppUI
{
    public class Program_UI
    {
        private readonly DeveloperRepository _developerRepo = new DeveloperRepository();
        private readonly DeveloperTeamRepository _developerTeamRepo = new DeveloperTeamRepository();
        private bool isRuning;

        public void Run()
        {
            RunApplication();
        }

        private void RunApplication()
        {
            bool isRunning = true;
            
            while (isRunning)
            {
                Console.WriteLine("Welcome to Developer Team Management Application\n" +
                "1.  Add a Developer\n" +
                "2.  View all Developers\n" +
                "3.  View a Single Developer\n" +
                "4.  Update a Developer\n" +
                "5.  Delete a Developer\n" +
                "---------------------------\n" +
                "6.  Add a team\n" +
                "7.  View all Teams\n" +
                "8.  View Single Team\n" +
                "9.  Update Team\n" +
                "10. Delete Team\n" +
                "50. Close Application\n");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        AddDeveloper();
                        break;
                    case "2":
                        ViewAllDevelopers();
                        break;
                    case "3":
                        ViewSingleDeveloper();
                        break;
                    case "4":
                        UpdateDeveloper();
                        break;
                    case "5":
                        DeleteDeveloper();
                        break;

                    case "6":
                        AddTeam();
                        break;
                    case "7":
                        ViewAllTeams();
                        break;
                    case "8":
                        ViewSingleTeam();
                        break;
                    // case "9":                
                    //    UpdateTeam();
                    case "10":
                        DeleteTeam();
                        break;

                    case "50":
                        isRuning = false;
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid selection");
                        Console.ReadKey();
                        break;

                }
                Console.Clear();
            }
        }

        private void DeleteTeam()
        {
            throw new NotImplementedException();
        }

        private void UpdateTeam()
        {
            throw new NotImplementedException();
        }

        private void ViewSingleTeam()
        {
            throw new NotImplementedException();
        }

        private void ViewAllTeams()
        {
            throw new NotImplementedException();
        }

        private void AddTeam()
        {
            throw new NotImplementedException();
        }

        private void DeleteDeveloper()
        {
            Console.Clear();
            Console.WriteLine("Please enter the developer ID:");
            var userInputDeveloperId = int.Parse(Console.ReadLine());

            bool success = _developerRepo.DeleteDeveloper(userInputDeveloperId);
            if (success)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Failure");
            }
            
        }

        private void UpdateDeveloper()
        {
            Console.Clear();
            Console.WriteLine("Please enter the developer ID:");
            var userInputDeveloperId = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Please enter developer first name:");
            var userInputFirstName = Console.ReadLine();

            Console.WriteLine("Please enter developer last name:");
            var userInputLastName = Console.ReadLine();

            Console.WriteLine("Does this developer have access to a Pluralsight account? (Y/N");
            Developer.HasPluralsight = GetYesNoAnswer();

            var newDeveloperData = new Developer(userInputFirstName, userInputLastName, Developer.HasPluralsight);
            bool success = _developerRepo.UpdateDeveloper(userInputDeveloperId, newDeveloperData);
            if (success)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Failure");
            }

        }

        private void ViewSingleDeveloper()
        {
            Console.Clear();
            Console.WriteLine("Please enter the developer ID:");
            var userInputDeveloperId = int.Parse(Console.ReadLine());

            Developer selectedDeveloper = _developerRepo.GetDeveloperByID(userInputDeveloperId);

            if (selectedDeveloper is null)
            {
                Console.WriteLine("This developer doesn't exist!");
            }
            else
            {
                DisplayDeveloperData(selectedDeveloper);
            }

            Console.ReadKey();
        }

        private void ViewAllDevelopers()
        {
            Console.Clear();
            List<Developer> developerInDatabase = _developerRepo.GetDeveloper().ToList();

            foreach(var developer in developerInDatabase)
            {
                DisplayDeveloperData(developer);
            }

            Console.ReadKey();
        }

        private void DisplayDeveloperData(Developer developer)
        {
            Console.WriteLine($"Developer ID {developer.ID}\n" +
                              $"Developer Name {developer.FirstName}\n" +
                              $"Developer Name {developer.LastName}\n");
            Console.WriteLine("--------------------------------------------");
                                                            
        }

        private bool GetYesNoAnswer()
        {
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "yes":
                    case "y":
                        return true;
                    case "no":
                    case "n":
                        return false;
                }
                Console.WriteLine("Please enter valid input");
            }
        }
        private void AddDeveloper()
        {
            Console.Clear();
            Console.WriteLine("Please enter developer first name:");
            var userInputFirstName = Console.ReadLine();

            Console.WriteLine("Please enter developer last name:");
            var userInputLastName = Console.ReadLine();

            Console.WriteLine("Does this developer have access to a Pluralsight account? (Y/N");
            Developer.HasPluralsight = GetYesNoAnswer();

            var developer = new Developer(userInputFirstName, userInputLastName, Developer.HasPluralsight);

            bool success = _developerRepo.AddDeveloper(developer);
            if (success)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.ReadKey();
        }
    }
}
