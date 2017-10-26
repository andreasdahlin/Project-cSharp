using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Presentation;


namespace NewLogic
{
    public class updateIntervall
    {
        private Dictionary<string, FeedTimer> listaTimer;
        
        public updateIntervall()
        {
            listaTimer= new Dictionary<string, FeedTimer>();

        }

            public async void EnableIntervalUpdateForFeeds(List<Podcast> poddiList)
            {

                foreach (var podcasts in poddiList)
                {
                    StartIntervalTimerForFeed(podcasts);

                }
            }
            public void ResetTimers()
            {
                foreach (var timer in listaTimer.Values)
                {
                    timer.Stop();
                    timer.Dispose();
                }
                listaTimer = new Dictionary<string, FeedTimer>();
            }


            public void StartIntervalTimerForFeed(Podcast pod)
            {
                if (!listaTimer.ContainsKey(pod.name))
                {
                    var timer = new FeedTimer(pod.interval) { Podcast = pod };
                    timer.Elapsed += TimerEventProcessor; //knyter metod till Timern
                    timer.Start();
                    listaTimer.Add(pod.name, timer); //Spara i dictianary för att se vilka podcasts som körs i klassen
                }
            }
            private async void TimerEventProcessor(object sender, ElapsedEventArgs e)
            {

                
                var timer = (FeedTimer)sender;
                var feed = (Podcast)timer.Podcast;

            // Hämta det ni har sparat i XML och hämta ny information från url och jämnföra att information överrenstämmer
                //var otherFeed = await GetFeedFromRssFeed(feed.Url);
                //if (otherFeed == null)
                //{
                //    return;
                //}
                //var feedItemsOld = feed.GetAllFeedItems();
                //var feedItemsNew = otherFeed.GetAllFeedItems();

                //if (feedItemsOld.Count != feedItemsNew.Count)
                //{
                //    var newFeeds = feedItemsNew.Except(feedItemsOld, new FeedItem.FeedItemComparer()).ToList();
                //    feed.AddFeedItems(newFeeds);
                //    var feedDataacess = new FeedDataacess();
                //    feedDataacess.UpdateFeed(feed);
            }
        }
    }

