namespace MoodAnalyzerTest
{
    public class TestAnalyzer
    {
        [Test]
        public void GivenMoodSad_AnalyzeMood_ReturnSadMood()
        {
            MoodAnayzer.AnalyzeMood mood = new MoodAnayzer.AnalyzeMood();
            string actualResult = mood.getMood("I am in Sad mood");
            Assert.AreEqual("Sad", actualResult);
        }
        [Test]
        public void GivenMoodAny_AnalyzeMood_ReturnHappyMood()
        {
            MoodAnayzer.AnalyzeMood mood = new MoodAnayzer.AnalyzeMood();
            string actualResult = mood.getMood("I am in Any mood");
            Assert.AreEqual("Happy", actualResult);
        }
    }
}