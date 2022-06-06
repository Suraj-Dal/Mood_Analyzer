namespace MoodAnalyzerTest
{
    public class TestAnalyzer
    {
        [Test]
        public void GivenMoodSad_AnalyzeMood_ReturnSadMood()
        {
            string message = "I am in Sad mood";
            MoodAnayzer.AnalyzeMood mood = new MoodAnayzer.AnalyzeMood(message);
            string actualResult = mood.getMood();
            Assert.AreEqual("Sad", actualResult);
        }
        [Test]
        public void GivenMoodAny_AnalyzeMood_ReturnHappyMood()
        {
            string message = "I am in Happy Mood";
            MoodAnayzer.AnalyzeMood mood = new MoodAnayzer.AnalyzeMood(message);
            string actualResult = mood.getMood();
            Assert.AreEqual("Happy", actualResult);
        }
    }
}