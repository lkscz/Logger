using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using ReadLogFiles;

namespace ReadLogFiles_Test
{
    [TestClass]
    public class LogFindErrors
    {


        [TestMethod]
        public void TestNoError()
        {
            ReadFiles readFiles = new ReadFiles();
            readFiles.Lines = new List<string> { "2023-11-02 13:52:47.5174;XEN-20;anthony.chassier;GestionSinistre.DefaultElenaLogger;CHASSIER ANTHONY s'est logué avec succes.;Info;;GestionSinistre.DefaultElenaLogger.Log;Control.WmShowWindow => Control.CreateControl => Control.CreateControl => Form.OnCreateControl => Form.OnLoad => EventHandler.Invoke => FRM_Accueil.FRM_Accueil_Load => CLS_GestionUtilisateurs.SeLoguerAD => GestionErreurs.Log => DefaultElenaLogger.Log;"};
            // error soit variable
            bool found = readFiles.ErrorFinder(readFiles.Lines[0], "error");
            Assert.IsTrue(!found);
        }

        [TestMethod]    
        public void TestErrorItemNotFound()
        {
            ReadFiles readFiles = new ReadFiles();
            readFiles.Lines = new List<string> { "2023 - 11 - 02 13:53:07.2829; XEN - 20; anthony.chassier; GestionSinistre.DefaultElenaLogger; Une erreur s'est produite lors de la récupération des rendez-vous exchange dans l'agenda Error Status Code: NotFound" };
            bool found = readFiles.ErrorFinder(readFiles.Lines[0], "NotFound");
            Assert.IsTrue(!found);
        }

        [TestMethod]
        public void TestError() 
        {
            ReadFiles readFiles = new ReadFiles();
            readFiles.Lines = new List<string> { "Error" };
            bool found = readFiles.ErrorFinder(readFiles.Lines[0], "error");
            Assert.IsTrue(!found);
        }

        [TestMethod]
        public void TestCountError()
        {
            ReadFiles readFiles = new ReadFiles();
            readFiles.Lines.Add("This is the first line named 0, I know it's a lil bit of strange but who cares. It isn't that important after all. It's an error because it shouldn't be called 0");
            readFiles.Lines.Add("So, this is the second line and guess what the name's. Yeah, it's 1 for the second one. I swear that their name is strange but, yeah, it's just a name. It's nothing that important so, let's keep going");
            readFiles.Lines.Add("Hey again ! How are ya ? Yeah, it's me again. You really thought I would have gave up that easily ? The answer is no. The name of this line is... Yeah, you truly got it, it's line 2 for the third line. Yeah, I got it. I'll stop... Nah, just kidding, see ya later.");
            readFiles.Lines.Add("Hello, it's the last time we'll see eachother, so I'll make it quick this time. The name of this line is 3 but it's the fourth line. An error again, but I think you're all used to those mistakes. I guess it's a farewell so... Take care and live happily");
            readFiles.FillLinesError();



            bool search = readFiles.ErrorFinder(readFiles.Lines[0], "error");
            bool found = readFiles.ErrorFinder(readFiles.Lines[3], "error");
            Assert.IsTrue(search);
            Assert.IsTrue(found);
            Assert.AreEqual(4, readFiles.Lines.Count);
            Assert.AreEqual(2, readFiles.LinesError.Count);
        }

        [TestMethod]
        
        public void RegrouperLesErreurs()
        {
            ReadFiles readFiles = new ReadFiles();
            readFiles.Lines.Add("Today, we'll test this new function I have just created, the name is Error");
            readFiles.Lines.Add("Error is a common thing that gives some problems to the employee of Equadex, more especially Anthony Chassier because he loves UnitTest");
            readFiles.Lines.Add("This is a UnitTest to see if the new function work well. If she can put all the errors in one line by telling how many timmes the errror reproduced herself. It's better than just having a hundred of lines");

            readFiles.StackErrors();
        }
    }
}
