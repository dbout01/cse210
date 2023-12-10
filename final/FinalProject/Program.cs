class Program
{
    static void Main()
    {
        // Creates instances of necessary classes
        WineCatalog wineCatalog = new WineCatalog();
        List<Wine> catalogWines = wineCatalog.GetCatalog();
        WineCellar wineCellar = new WineCellar();
        wineCellar.AddWines(catalogWines);
        WineStatistics wineStatistics = new WineStatistics(wineCellar.GetWines());
        FileHandler fileHandler = new FileHandler();
        UserInterface userInterface = new UserInterface();
        ValidationHelper validationHelper = new ValidationHelper();

        // Initializes WineCellarManager with necessary components and run the program
        WineCellarManager cellarManager = new WineCellarManager(wineCellar, wineCatalog, wineStatistics, fileHandler, userInterface, validationHelper);
        cellarManager.RunProgram();
    }
}