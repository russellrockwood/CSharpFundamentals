using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor.UI
{
    public class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository();
        private IConsole _console;
        public ProgramUI(IConsole console)
        {
            _console = console;
        }

        public void Run()
        {
            SeedContentList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                _console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                string userInput = _console.ReadLine();

                switch (userInput.ToLower())
                {
                    case "1":
                    case "one":
                        CreateNewContent();
                        break;

                    case "2":
                    case "two":
                        DisplayAllContent();
                        break;

                    case "3":
                    case "three":
                        DisplayContentByTitle();
                        break;

                    case "4":
                    case "four":
                        UpdateContent();
                        break;

                    case "5":
                    case "five":
                        DeleteContent();
                        break;

                    case "6":
                    case "six":
                        keepRunning = false;
                        break;

                    default:
                        _console.WriteLine("Please enter a valid number");
                        break;
                }
                _console.WriteLine("Press any key to continue");
                _console.ReadKey();
                _console.Clear();
            }

        }
        private void CreateNewContent() // challenge - ask the user to confirm info before adding to directory
        {
            _console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title
            _console.WriteLine("What is the title for this content?");
            newContent.Title = _console.ReadLine();

            //Description
            _console.WriteLine("Enter the description of the content");
            newContent.Description = _console.ReadLine();

            //Star Rating
            _console.WriteLine("Enter the star rating for this content (0.0 - 5.0)");
            string starRatingAsString = _console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            //newContent.StarRating = Convert.ToDouble(Console.ReadLine()); same as above

            //GenreType
            _console.WriteLine("Enter the Genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            string genreAsString = _console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //Maturity Rating
            _console.WriteLine("Enter the maturity rating for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_14\n" +
                "8. TV_MA\n");

            string maturityRatingAsString = _console.ReadLine();
            int maturityRatingAsInt = Convert.ToInt32(maturityRatingAsString);
            newContent.MaturityRating = (MaturityRating)maturityRatingAsInt;
            // newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine()); -Same as above

            bool wasAddedCorrectly = _repo.AddContentToDirectory(newContent);
            if (wasAddedCorrectly)
            {
                _console.WriteLine("The content was added correctly!");
            }
            else
            {
                _console.WriteLine("Could not add content.");
            }
        }

        private void DisplayAllContent()
        {
            _console.Clear();
            List<StreamingContent> allContent = _repo.GetContents();

            foreach (StreamingContent content in allContent)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                _console.WriteLine($"Title: {content.Title}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}");
                Console.ResetColor();
            }
        }

        private void DisplayContentByTitle() // Get all info about user selected title and return
        {
            _console.Clear();
            //DisplayAllContent();
            List<StreamingContent> allContent = _repo.GetContents();
            _console.WriteLine("Enter the title you are searching for:");

            StreamingContent contentToDisplay = _repo.GetContentByTitle(Console.ReadLine());

            if (contentToDisplay != null)
            {
                _console.WriteLine($"Title: {contentToDisplay.Title}\n" +
                        $"Description: {contentToDisplay.Description}\n" +
                        $"Genre: {contentToDisplay.TypeOfGenre}\n" +
                        $"Rotten Tomatoes: {contentToDisplay.StarRating}\n" +
                        $"Maturity Rating: {contentToDisplay.MaturityRating}\n" +
                        $"Family Friendly: {contentToDisplay.IsFamilyFriendly}");
            }
            else
            {
                _console.WriteLine("There is no content by that title.");
            }
        }

        private void UpdateContent()
        {
            _console.Clear();
            DisplayAllContent();
            _console.WriteLine("Enter title of content you want to update.");

            string oldTitle = _console.ReadLine();

            StreamingContent newContent = new StreamingContent();

            //Title
            _console.WriteLine("What is the title for this content?");
            newContent.Title = _console.ReadLine();

            //Descriptioin
            _console.WriteLine("Enter the description of the content");
            newContent.Description = _console.ReadLine();

            //Star Rating
            _console.WriteLine("Enter the star rating for this content (0.0 - 5.0)");
            string starRatingAsString = _console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            //newContent.StarRating = Convert.ToDouble(Console.ReadLine()); same as above

            //GenreType
            _console.WriteLine("Enter the Genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            string genreAsString = _console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //Maturity Rating
            _console.WriteLine("Enter the maturity rating for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_14\n" +
                "8. TV_MA\n");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(_console.ReadLine());

            bool wasUpdated = _repo.UpdateExistingContent(oldTitle, newContent);
            if (wasUpdated)
            {
                _console.WriteLine("Content was succcessfully updated.");
            }
            else
            {
                _console.WriteLine("No content by that title existes");
            }
        }

        private void DeleteContent()
        {
            _console.Clear();
            DisplayAllContent();

            _console.WriteLine("Enter the title for the content you want to delete:");

            bool wasDeleted = _repo.DeleteExistingContent(_console.ReadLine());

            if (wasDeleted)
            {
                _console.WriteLine("Content succesfully deleted.");
            }
            else
            {
                _console.WriteLine("Content could not be deleted.");
            }
        }

        private void SeedContentList()
        {
            StreamingContent future = new StreamingContent("Back to the Future", "Marty gets transported back in time.", 4.5, GenreType.SciFi, MaturityRating.PG);
            StreamingContent starWars = new StreamingContent("Star Wars", "Bunch of fighting on the stars.", 3.1, GenreType.SciFi, MaturityRating.PG_13);
            StreamingContent rubber = new StreamingContent("Rubber", "Car tire comes to life.", 2.1, GenreType.Horror, MaturityRating.R);

            _repo.AddContentToDirectory(future);
            _repo.AddContentToDirectory(starWars);
            _repo.AddContentToDirectory(rubber);

        }
    }
}
