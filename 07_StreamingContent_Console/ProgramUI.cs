using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _07_StreamingContent_Console
{
    public class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository();

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

                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                string userInput = Console.ReadLine();

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
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }

        }
        private void CreateNewContent() // challenge - ask the user to confirm info before adding to directory
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("What is the title for this content?");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description of the content");
            newContent.Description = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the star rating for this content (0.0 - 5.0)");
            string starRatingAsString = Console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            //newContent.StarRating = Convert.ToDouble(Console.ReadLine()); same as above

            //GenreType
            Console.WriteLine("Enter the Genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            string genreAsString = Console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //Maturity Rating
            Console.WriteLine("Enter the maturity rating for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_14\n" +
                "8. TV_MA\n");

            string maturityRatingAsString = Console.ReadLine();
            int maturityRatingAsInt = Convert.ToInt32(maturityRatingAsString);
            newContent.MaturityRating = (MaturityRating)maturityRatingAsInt;
            // newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine()); -Same as above

            bool wasAddedCorrectly = _repo.AddContentToDirectory(newContent);
            if (wasAddedCorrectly)
            {
                Console.WriteLine("The content was added correctly!");
            }
            else
            {
                Console.WriteLine("Could not add content.");
            }
        }

        private void DisplayAllContent()
        {
            Console.Clear();
            List<StreamingContent> allContent = _repo.GetContents();

            foreach (StreamingContent content in allContent)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}");
                Console.ResetColor();
            }
        }

        private void DisplayContentByTitle() // Get all info about user selected title and return
        {
            Console.Clear();
            //DisplayAllContent();
            List<StreamingContent> allContent = _repo.GetContents();
            Console.WriteLine("Enter the title you are searching for:");

            StreamingContent contentToDisplay = _repo.GetContentByTitle(Console.ReadLine());

            if (contentToDisplay != null)
            {
                Console.WriteLine($"Title: {contentToDisplay.Title}\n" +
                        $"Description: {contentToDisplay.Description}\n" +
                        $"Genre: {contentToDisplay.TypeOfGenre}\n" +
                        $"Rotten Tomatoes: {contentToDisplay.StarRating}\n" +
                        $"Maturity Rating: {contentToDisplay.MaturityRating}\n" +
                        $"Family Friendly: {contentToDisplay.IsFamilyFriendly}");
            }
            else
            {
                Console.WriteLine("There is no content by that title.");
            }
        }

        private void UpdateContent()
        {
            Console.Clear();
            DisplayAllContent();
            Console.WriteLine("Enter title of content you want to update.");

            string oldTitle = Console.ReadLine();

            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("What is the title for this content?");
            newContent.Title = Console.ReadLine();

            //Descriptioin
            Console.WriteLine("Enter the description of the content");
            newContent.Description = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the star rating for this content (0.0 - 5.0)");
            string starRatingAsString = Console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            //newContent.StarRating = Convert.ToDouble(Console.ReadLine()); same as above

            //GenreType
            Console.WriteLine("Enter the Genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            string genreAsString = Console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //Maturity Rating
            Console.WriteLine("Enter the maturity rating for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_14\n" +
                "8. TV_MA\n");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine());

            bool wasUpdated =_repo.UpdateExistingContent(oldTitle, newContent);
            if (wasUpdated)
            {
                Console.WriteLine("Content was succcessfully updated.");
            }
            else
            {
                Console.WriteLine("No content by that title existes");
            }
        }

        private void DeleteContent()
        {
            Console.Clear();
            DisplayAllContent();

            Console.WriteLine("Enter the title for the content you want to delete:");

            bool wasDeleted = _repo.DeleteExistingContent(Console.ReadLine());

            if (wasDeleted)
            {
                Console.WriteLine("Content succesfully deleted.");
            }
            else
            {
                Console.WriteLine("Content could not be deleted.");
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
