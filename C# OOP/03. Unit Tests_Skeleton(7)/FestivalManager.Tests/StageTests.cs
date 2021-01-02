// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 

namespace FestivalManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
	public class StageTests
	{
		private Performer performer;
		private Song song;
		private Stage stage;
    	[SetUp]
        public void Initialize() 
        {
	        stage = new Stage();
        }
		[Test]
	    public void InitializesPerformer()
	    {
		    performer = new Performer("Pesho", "Ivanov", 20);
		    Assert.AreEqual(performer.FullName, "Pesho Ivanov");
		    Assert.AreEqual(performer.Age, 20);
		}

	    [Test]
	    public void InitializesSong()
	    {
		    DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
		    DateTime date2 = new DateTime(2010, 8, 18, 13, 30, 30);
		    TimeSpan timeSpan = date2 - date1;
		    song = new Song("Test", timeSpan);
		    Assert.AreEqual(song.Name, "Test");
		    Assert.AreEqual(timeSpan, timeSpan);
	    }
	    
	    
	    [Test]
	    public void InitializesStage()
	    {
		    stage = new Stage();
		    Assert.AreEqual(stage.Performers.Count, 0);
	    }
	    
	    [Test]
	    public void AddsANewPerformer()
	    {
		    performer = new Performer("Pesho", "Ivanov", 20);
		    stage.AddPerformer(performer);
		    Assert.AreEqual(stage.Performers.Count, 1);
	    }
	    
	    [Test]
	    public void CantAddNullPerformer()
	    {
		    Assert.That(() => stage.AddPerformer(null), Throws
			    .ArgumentNullException.With.Message.EqualTo("Can not be null! (Parameter 'performer')"));
	    }
	    
	    [Test]
	    public void CantAddUnderagePerformer()
	    {
		    Performer underage = new Performer("Lape", "Lape", 17);
		    Assert.That(() => stage.AddPerformer(underage), Throws
			    .ArgumentException.With.Message.EqualTo("You can only add performers that are at least 18."));
	    }
	    
	    [Test]
	    public void AddsSongs()
	    {
		    DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
		    DateTime date2 = new DateTime(2010, 8, 18, 13, 30, 30);
		    TimeSpan timeSpan = date2 - date1;
		    song = new Song("Test", timeSpan);
	    }
	    
	    [Test]
	    public void ThrowsExceptionIfAddNullSong()
	    {
		    Assert.That(() => stage.AddSong(null), Throws
			    .ArgumentNullException.With.Message.EqualTo("Can not be null! (Parameter 'song')"));
	    }
	    
	    [Test]
	    public void CantAddSongWithShortDuration()
	    {
		    DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
		    DateTime date2 = new DateTime(2010, 1, 1, 8, 0, 16);
		    TimeSpan timeSpan = date2 - date1;
		    Song song = new Song("Test", timeSpan);
		    Assert.That(() => stage.AddSong(song), Throws
			    .ArgumentException.With.Message.EqualTo("You can only add songs that are longer than 1 minute."));
	    }
	    
	    [Test]
	    public void AddsSongToPerformer()
	    {
		    performer = new Performer("Pesho", "Ivanov", 20);
		    DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
		    DateTime date2 = new DateTime(2010, 1, 1, 8, 1, 16);
		    TimeSpan timeSpan = date2 - date1;
		    Song song = new Song("Test", timeSpan);
		    stage.AddPerformer(performer);
		    stage.AddSong(song);
		    Assert.AreEqual(stage.AddSongToPerformer("Test", "Pesho Ivanov"), "Test (01:01) will be performed by Pesho Ivanov");
	    }
	    
	    [Test]
	    public void CantAddSongToNonExistingPerformer()
	    {
		    performer = new Performer("Pesho", "Ivanov", 20);
		    DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
		    DateTime date2 = new DateTime(2010, 1, 1, 8, 1, 16);
		    TimeSpan timeSpan = date2 - date1;
		    Song song = new Song("Test", timeSpan);
		    stage.AddSong(song);
		    Assert.That(() => stage.AddSongToPerformer("Test", "Pesho Ivanov"), Throws
			    .ArgumentException.With.Message.EqualTo("There is no performer with this name."));
	    }
	    
	    public void CantAddNonExistingSongToPerformer()
	    {
		    performer = new Performer("Pesho", "Ivanov", 20);
		    DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
		    DateTime date2 = new DateTime(2010, 1, 1, 8, 1, 16);
		    TimeSpan timeSpan = date2 - date1;
		    Song song = new Song("Test", timeSpan);
		    stage.AddPerformer(performer);
		    Assert.That(() => stage.AddSongToPerformer("Test", "Pesho Ivanov"), Throws
			    .ArgumentException.With.Message.EqualTo("There is no song with this name."));
	    }

	    public void PlayFunctionWorks()
	    {
		    performer = new Performer("Pesho", "Ivanov", 20);
		    DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
		    DateTime date2 = new DateTime(2010, 1, 1, 8, 2, 16);
		    TimeSpan timeSpan = date2 - date1;
		    Song song = new Song("Test", timeSpan);
		    Song second = new Song("Test 2", timeSpan);
		    stage.AddPerformer(performer);
		    stage.AddSong(song);
		    stage.AddSongToPerformer(song.Name, performer.FullName);
		    stage.AddSongToPerformer(second.Name, performer.FullName);
		    Assert.AreEqual(stage.Play(), "1 performers played 2 songs");
	    }
	}
}