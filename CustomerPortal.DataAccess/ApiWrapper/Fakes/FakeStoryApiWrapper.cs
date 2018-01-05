// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="FakeStoryApiWrapper.cs" company="Grosvenor">
// //   
// // </copyright>
// // <summary>
// //   FakeStoryApiWrapper
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.ApiWrapper.Fakes
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// Fake story API wrapper.
    /// </summary>
    public class FakeStoryApiWrapper : FakeAipWrapperBase, IStoryApiWrapper
    {
        public async Task<HttpResponseMessage> GetStories(
            string accessToken,
            string type,
            string tagsList,
            int pageToGet,
            int numberOfItems,
            bool filterByLocation)
        {
            var content = string.Empty;

            if (type.ToLower() == "story")
            {
                content = "{\"Stories\":[{\"StoryStatus\":null,\"Tags\":[{\"Id\":\"3612ab85-8719-430c-9311-f4effb28f50e\",\"StoryId\":\"5f32f402-f783-4ffc-a8ff-3e1e68201b28\",\"Tag\":\"Cinema\"},{\"Id\":\"a88211a2-2c6e-48a0-8324-f6bfffe33293\",\"StoryId\":\"5f32f402-f783-4ffc-a8ff-3e1e68201b28\",\"Tag\":\" Sustainability\"}],\"Theme\":null,\"Id\":\"5f32f402-f783-4ffc-a8ff-3e1e68201b28\",\"Category\":\"Feature\",\"DateCreated\":\"2016-11-01T18:01:27\",\"DateModified\":\"2016-11-03T11:40:36.38\",\"HtmlContent\":\"\\n    <div class=\\\"grid-100 p20\\\">\\r\\n  <h4 style=\\\"text-align: center;\\\">\\r\\n\\tINFOGRAPHIC</h4>\\r\\n<h1 class=\\\"fontnewcentury\\\" style=\\\"text-align: center;\\\">\\r\\n\\tLights, camera, social action!</h1>\\r\\n<div style=\\\"text-align: center;\\\">\\r\\n\\t<p style=\\\"margin:0cm;margin-bottom:.0001pt\\\">\\r\\n\\t\\t<b>The Nomad Cinema spent the summer popping up at sites across " +
                    "Mayfair and Belgravia, but its impact was felt much further afield</b><o:p></o:p></p>\\r\\n</div>\\r\\n<br>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n</div><div class=\\\"grid-100 padbot\\\">\\r\\n  <img id=\\\"p_lt_ctl04_pageplaceholder_p_lt_ctl00_FullWidthImage_ucEditableImage_imgImage\\\" src=\\\"/getattachment/News-Stories/Lights,-camera,-social-action!/4134_Nomad_Infographic_web.png\\\" alt=\\\"\\\">\\r\\n\\r\\n</div><div class=\\\"box grid-66 padbot bodyamp\\\">\\n  <div class=\\\"grid-parent\\\">\\n  \\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><div class=\\\"box grid-33\\\">\\n  <div class=\\\"grid-parent\\\">\\n  \\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><div class=\\\"box grid-66 padbot bodyamp\\\">\\n  <div class=\\\"grid-parent\\\">\\n  \\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><div class=\\\"box grid-66 padbot bodyamp\\\">\\n  <div class=\\\"grid-parent\\\">\\n  \\r\\n\\r\\n\\r\\n\\r\\n\\n " +
                    " </div>\\n</div><hr>\\r\\n<div class=\\\"clear\\\">\\r\\n\\t&nbsp;</div>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n<script type=\\\"text/javascript\\\">\\r\\n    $(function () {\\r\\n        $('.newsletter_chronicle .button').click(function () {\\r\\n            var t = $('.newsletter_chronicle .textbox').val();\\r\\n            return t != null && t.length > 0;\\r\\n        });\\r\\n    });\\r\\n</script>\\r\\n\\n  \",\"ImageAlt\":\"\",\"ImageUrl\":\"http://www.grosvenorlondon.com/getattachment/News-Stories/Lights,-camera,-social-action!/HomepageGraphic-(1).jpg\",\"StoryFormat\":\"LeftImage\",\"StoryId\":101,\"StoryUrl\":\"http://www.grosvenorlondon.com/News-Stories/Lights,-camera,-social-action!\",\"Title\":\"Lights, camera, social action!\",\"VideoUrl\":\"\",\"StoryType\":\"story\",\"Location\":null,\"Description\":null,\"BuisnessName\":null,\"BuisnessContact\":null,\"ValidUntilDate\":null,\"Status\":null," +
                    "\"ThemeId\":null,\"UpdatedBy\":null},{\"StoryStatus\":null,\"Tags\":[{\"Id\":\"e42d2c82-5513-4583-8990-5486c2a9a76d\",\"StoryId\":\"a08090d8-5a13-4a05-bb43-037e89593543\",\"Tag\":\" Fashion\"},{\"Id\":\"ceb2bfa5-38c4-41bb-b249-a8ea704ee885\",\"StoryId\":\"a08090d8-5a13-4a05-bb43-037e89593543\",\"Tag\":\"Mayfair\"},{\"Id\":\"00caf0be-deec-49b7-a5e1-dea4779c837c\",\"StoryId\":\"a08090d8-5a13-4a05-bb43-037e89593543\",\"Tag\":\" Retail\"}],\"Theme\":null,\"Id\":\"a08090d8-5a13-4a05-bb43-037e89593543\",\"Category\":\"Film\",\"DateCreated\":\"2016-10-21T15:57:18\",\"DateModified\":\"2016-10-31T12:23:06.247\",\"HtmlContent\":\"\\n    <div class=\\\"grid-100 p20\\\">\\r\\n  <h4 style=\\\"text-align: center;\\\">\\r\\n\\tFILM</h4>\\r\\n<h1 class=\\\"fontnewcentury\\\" style=\\\"text-align: center;\\\">\\r\\n\\tA marriage of creative minds</h1>\\r\\n<div style=\\\"text-align: center;\\\">\\r\\n\\tMeet John and " +
                    "Monique Davidson, the stylish couple behind Mount Street&#39;s latest boutique launch<br>\\r\\n\\t&nbsp;</div>\\r\\n&nbsp;<iframe align=\\\"middle\\\" allowfullscreen=\\\"\\\" frameborder=\\\"0\\\" height=\\\"495\\\" mozallowfullscreen=\\\"\\\" scrolling=\\\"no\\\" src=\\\"https://player.vimeo.com/video/188295660\\\" webkitallowfullscreen=\\\"\\\" width=\\\"880\\\"></iframe>\\r\\n\\r\\n\\r\\n\\r\\n</div><div class=\\\"box grid-66 padbot bodyamp\\\">\\n  <div class=\\\"grid-parent\\\">\\n  \\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><div class=\\\"box grid-33\\\">\\n  <div class=\\\"grid-parent\\\">\\n  \\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><div class=\\\"box grid-66 padbot bodyamp\\\">\\n  <div class=\\\"grid-parent\\\">\\n  \\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><div class=\\\"box grid-66 padbot bodyamp\\\">\\n  <div class=\\\"grid-parent\\\">\\n  \\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div>" +
                    "<hr>\\r\\n<div class=\\\"clear\\\">\\r\\n\\t&nbsp;</div>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n<script type=\\\"text/javascript\\\">\\r\\n    $(function () {\\r\\n        $('.newsletter_chronicle .button').click(function () {\\r\\n            var t = $('.newsletter_chronicle .textbox').val();\\r\\n            return t != null && t.length > 0;\\r\\n        });\\r\\n    });\\r\\n</script>\\r\\n\\n  \",\"ImageAlt\":\"J&M Davidson: A marriage of creative minds\",\"ImageUrl\":\"http://www.grosvenorlondon.com/news-stories/images-(1)/october-2016/j-m-davidson/4174_jm_still-(1).jpg\",\"StoryFormat\":\"TopImage\",\"StoryId\":100,\"StoryUrl\":\"http://www.grosvenorlondon.com/News-Stories/J-M-Davidson:-A-marriage-of-creative-minds\",\"Title\":\"J&M Davidson: A marriage of creative minds\",\"VideoUrl\":\"https://player.vimeo.com/video/188295660\",\"StoryType\":\"story\",\"Location\":null,\"Description\":null,\"BuisnessName\"" +
                    ":null,\"BuisnessContact\":null,\"ValidUntilDate\":null,\"Status\":null,\"ThemeId\":null,\"UpdatedBy\":null},{\"StoryStatus\":null,\"Tags\":[{\"Id\":\"84705ee3-9903-43f7-9ff1-2b8ab340f336\",\"StoryId\":\"228afe4b-e488-4dad-bdc9-ec0b03f12205\",\"Tag\":\"Belgravia\"},{\"Id\":\"771675d6-a74f-4b9b-89bc-4b7016599ea8\",\"StoryId\":\"228afe4b-e488-4dad-bdc9-ec0b03f12205\",\"Tag\":\" Food and drink\"}],\"Theme\":null,\"Id\":\"228afe4b-e488-4dad-bdc9-ec0b03f12205\",\"Category\":\"Feature\",\"DateCreated\":\"2016-10-12T16:27:45\",\"DateModified\":\"2016-10-12T17:13:43.053\",\"HtmlContent\":\"\\n    <div class=\\\"grid-100 p20\\\">\\r\\n  <h4 style=\\\"text-align: center;\\\">\\r\\n\\tFEATURE</h4>\\r\\n<h1 class=\\\"fontnewcentury\\\" style=\\\"text-align: center;\\\">\\r\\n\\tBaked to perfection</h1>\\r\\n<div style=\\\"text-align: center;\\\">\\r\\n\\tDominique Ansel, famed for his inventive recipes and reputation " +
                    "as a real-life Willy Wonka, talks to us about his recently launched</div>\\r\\n<div style=\\\"text-align: center;\\\">\\r\\n\\tbakery in Belgravia</div>\\r\\n<br>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n</div><div class=\\\"grid-100 padbot\\\">\\r\\n  <img id=\\\"p_lt_ctl04_pageplaceholder_p_lt_ctl00_FullWidthImage_ucEditableImage_imgImage\\\" src=\\\"http://www.grosvenorlondon.com/news-stories/images-(1)/october-2016/baked-to-perfection/interior2_hero.jpg\\\" alt=\\\"Dominique Ansel Bakery\\\">\\r\\n\\r\\n</div><div class=\\\"box grid-66 padbot bodyamp\\\">\\n  <div class=\\\"grid-parent\\\">\\n  <a href=\\\"http://www.nationalbakingweek.co.uk/\\\" target=\\\"_blank\\\">National Baking Week</a> is likely to inspire a <em>Great British Bake Off</em>-obsessed nation into the kitchen to experiment with new and ambitious recipes. Few can dream of achieving the success of French pastry chef Dominique Ansel, but anyone " +
                    "who&rsquo;s ever been curious about a Cronut&reg; can now pick one up in London. Happily, <a href=\\\"http://dominiqueansellondon.com/\\\" target=\\\"_blank\\\">the Dominique Ansel Bakery</a> opened its latest branch in Elizabeth Street in Belgravia in September.<br>\\r\\n&nbsp;<br>\\r\\nDominique&rsquo;s Cronut&reg; &ndash; a cross between a croissant and a doughnut &ndash; made headlines around the world upon its creation in 2013. A playful inventiveness is at the heart of everything Dominique serves in his bakeries, along with a lot of hard work. The Dominique Ansel Bakery in London is the fourth of its kind, in addition to two branches in his adopted home of New York and one in Tokyo. Belgravia&rsquo;s community feel was integral to him setting up shop there.<br>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><div class=\\\"grid-66 padbot\\\">\\r\\n  <img id=\\\"p_lt_ctl04_pageplaceholder_p_lt_ctl00_Image66_ucEditableImage_imgImage\\\" " +
                    "src=\\\"http://www.grosvenorlondon.com/news-stories/images-(1)/october-2016/baked-to-perfection/chocolate-chip-cookie-shot-landscape.jpg\\\" alt=\\\"Dominique Ansel Bakery\\\">\\r\\n\\r\\n</div><div class=\\\"grid-33 norightpad padbot\\\">\\r\\n  <img id=\\\"p_lt_ctl04_pageplaceholder_p_lt_ctl00_image33a1_ucEditableImage_imgImage\\\" src=\\\"http://www.grosvenorlondon.com/news-stories/images-(1)/october-2016/baked-to-perfection/cronut-hi-res_portrait.jpg\\\" alt=\\\"Dominique Ansel Bakery\\\">\\r\\n\\r\\n</div><div class=\\\"box grid-33\\\">\\n  <div class=\\\"grid-parent\\\">\\n  \\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><div class=\\\"box grid-66 padbot bodyamp\\\">\\n  <div class=\\\"grid-parent\\\">\\n  &ldquo;A bakery is a local business,&rdquo; he explains. &ldquo;We need customers to come every day and to have an interaction. Belgravia is a beautiful neighbourhood and very charming.&rdquo;<br>\\r\\n&nbsp;<br>\\r\\n<strong>Regional " +
                    "ingredients </strong><br>\\r\\nAfter falling in love with working in kitchens in Paris, Dominique began his career as a pastry chef at legendary gourmet food and delicatessen company, Fauchon.<br>\\r\\n&nbsp;<br>\\r\\n&ldquo;After eight years I was in charge of international openings and travel,&rdquo; he says. &ldquo;I was travelling the world and training people, so I definitely learned a lot at Fauchon.&rdquo;<br>\\r\\n&nbsp;<br>\\r\\nThis international experience led to Dominique being offered a job in New York by French chef and restaurateur Daniel Boulud in 2006. Five years later, the first Dominique Ansel Bakery was born.<br>\\r\\n&nbsp;<br>\\r\\n&ldquo;I found this beautiful, tiny shop in SoHo in New York and decided to take the big step and open my own shop,&rdquo; he says. &ldquo;I left Daniel and opened with just four employees at the time. It was very simple, very humble and we worked very hard every day to deliver good " +
                    "quality food and to change the menu with the seasons.&rdquo;<br>\\r\\n&nbsp;<br>\\r\\nDominique&rsquo;s use of regional ingredients and new takes on classic dishes is part of his food&rsquo;s allure. He adapts the menu of each bakery based on its location and estimates that more than a third of each menu is dedicated to unique dishes inspired by local ingredients and his research into different countries&rsquo; culinary cultures.<br>\\r\\n&nbsp;<br>\\r\\n<strong>Banoffee paella and more</strong><br>\\r\\nThis raises the question of what surprises Dominique has on the menu at his new London location.<br>\\r\\n&nbsp;<br>\\r\\n&ldquo;A banoffee paella,&rdquo; he chuckles, &ldquo;which we prepare in a paella pan so it&rsquo;s a little bit upside down. We cut it, flip it on the plate and serve it with a big dollop of whipped cream and some beautiful caramelised banana. We add a very light cream and a little cookie crumble. It&rsquo;s " +
                    "really delicious and the presentation is fun.&rdquo;<br>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><div class=\\\"grid-66 padbot\\\">\\r\\n  <img id=\\\"p_lt_ctl04_pageplaceholder_p_lt_ctl00_Image1_ucEditableImage_imgImage\\\" src=\\\"http://www.grosvenorlondon.com/news-stories/images-(1)/october-2016/baked-to-perfection/interior3_landscape.jpg\\\" alt=\\\"Dominique Ansel Bakery\\\">\\r\\n\\r\\n</div><div class=\\\"box grid-66 padbot bodyamp\\\">\\n  <div class=\\\"grid-parent\\\">\\n  Dominique has also utilised what he refers to as the &ldquo;worldwide influence&rdquo; on London&rsquo;s cuisine to create a French-Indian dish.<br>\\r\\n&nbsp;<br>\\r\\n&ldquo;We&rsquo;re also doing what we call the dosa mille feuille,&rdquo; he reveals. &ldquo;It&rsquo;s a very thin puff pastry &ndash; super thin, like paper &ndash; that is shaped like a dosa (a kind of Indian pancake, made from a fermented batter). We pipe in a very light " +
                    "hazelnut cream with some lemon confit. It&rsquo;s a different presentation &ndash; really unique and exciting.&rdquo;<br>\\r\\n&nbsp;<br>\\r\\nFinally, he&rsquo;s also made room for a new take on a British classic, the Eton Mess.<br>\\r\\n&nbsp;<br>\\r\\n&ldquo;We serve it in a small box, almost like a lunch box,&rdquo; he explains. &ldquo;It looks like some beautiful strawberries that are delicately dropped in a box. We&rsquo;re asking people to take the box and shake it to make the Eton Mess. It&rsquo;s really fun.&rdquo;<br>\\r\\n&nbsp;<br>\\r\\nThere are also plans to add a high tea to the menu later this year.<br>\\r\\n&nbsp;<br>\\r\\nDominique admits it can take anywhere between a few days and a few months to perfect a new dish.<br>\\r\\n&nbsp;<br>\\r\\n&ldquo;It&rsquo;s about knowing what we can do technically, scientifically and how we can combine the ideas,&rdquo; he says. &ldquo;I was working on the banoffee paella for " +
                    "about two months!&rdquo;<br>\\r\\n&nbsp;<br>\\r\\nAs that suggests, Dominique takes a patient approach to perfecting dishes.<br>\\r\\n&nbsp;<br>\\r\\n&ldquo;I believe in a culture where chefs are calm, good teachers and leaders,&rdquo; says the man who&rsquo;s banned swearing in his kitchens. &ldquo;You can see a lot of good results: employees aren&rsquo;t afraid of asking questions, so they grow faster and stay longer with us. When I see my customers happy and my team happy, I can&rsquo;t ask for anything else.&rdquo;<br>\\r\\n&nbsp;<br>\\r\\n<em>Head to 17-21 Elizabeth Street to try one of Dominique&rsquo;s latest creations.</em><br>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><div class=\\\"grid-33 norightpad padbot\\\">\\r\\n  <img id=\\\"p_lt_ctl04_pageplaceholder_p_lt_ctl00_Image33c3_ucEditableImage_imgImage\\\" src=\\\"http://www.grosvenorlondon.com/news-stories/images-(1)/october-2016/baked-to-perfection/frozen-s-mores_portrait.jpg\\\" " +
                    "alt=\\\"Dominique Ansel Bakery\\\">\\r\\n\\r\\n</div><hr>\\r\\n<div class=\\\"clear\\\">\\r\\n\\t&nbsp;</div>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n<script type=\\\"text/javascript\\\">\\r\\n    $(function () {\\r\\n        $('.newsletter_chronicle .button').click(function () {\\r\\n            var t = $('.newsletter_chronicle .textbox').val();\\r\\n            return t != null && t.length > 0;\\r\\n        });\\r\\n    });\\r\\n</script>\\r\\n\\n  \",\"ImageAlt\":\"Dominique Ansel Bakery\",\"ImageUrl\":\"http://www.grosvenorlondon.com/news-stories/images-(1)/october-2016/baked-to-perfection/interior2_home.jpg\",\"StoryFormat\":\"TopImage\",\"StoryId\":99,\"StoryUrl\":\"http://www.grosvenorlondon.com/News-Stories/Baked-to-perfection\",\"Title\":\"Baked to perfection\",\"VideoUrl\":\"\",\"StoryType\":\"story\",\"Location\":null,\"Description\":null,\"BuisnessName\":null,\"BuisnessContact\":null,\"ValidUntilDate\":null,\"Status\":null,\"ThemeId\":null,\"UpdatedBy\"" +
                    ":null},{\"StoryStatus\":null,\"Tags\":[{\"Id\":\"ca7801fb-5319-4889-8c50-5ca1e869b5e1\",\"StoryId\":\"a7efaeee-20ae-44fb-a3ca-3a25094707c5\",\"Tag\":\" Art\"},{\"Id\":\"fd5c54c6-5f8d-418e-8eac-7f8205805e7e\",\"StoryId\":\"a7efaeee-20ae-44fb-a3ca-3a25094707c5\",\"Tag\":\"Mayfair\"},{\"Id\":\"660f02c3-afc3-469c-bc5c-b26695840c1b\",\"StoryId\":\"a7efaeee-20ae-44fb-a3ca-3a25094707c5\",\"Tag\":\" Fashion\"}],\"Theme\":null,\"Id\":\"a7efaeee-20ae-44fb-a3ca-3a25094707c5\",\"Category\":\"Feature\",\"DateCreated\":\"2016-10-05T16:41:40\",\"DateModified\":\"2016-10-07T14:40:05.963\",\"HtmlContent\":\"\\n    <div class=\\\"grid-100 p20\\\">\\r\\n  <h4 style=\\\"text-align: center;\\\">\\r\\n\\tFEATURE</h4>\\r\\n<h1 class=\\\"fontnewcentury\\\" style=\\\"text-align: center;\\\">\\r\\n\\tMount Street&#39;s secret art trail</h1>\\r\\n<div style=\\\"text-align: center;\\\">\\r\\n\\tWe explore the Mount Street brands fusing contemporary art with fashion&nbsp;</div>\\r\\n" +
                    "<br>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n</div><div class=\\\"grid-100 padbot\\\">\\r\\n  <img id=\\\"p_lt_ctl04_pageplaceholder_p_lt_ctl00_FullWidthImage_ucEditableImage_imgImage\\\" src=\\\"http://www.grosvenorlondon.com/news-stories/images-(1)/october-2016/mount-street%e2%80%99s-secret-art-trail/featuredhero.jpg\\\" alt=\\\"J&amp;M Davidson floral ceiling installation\\\">\\r\\n\\r\\n</div><div class=\\\"box grid-66 padbot bodyamp\\\">\\n  <div class=\\\"grid-parent\\\">\\n  Regardless of the time of year, London is an art lover&rsquo;s dream, with a never-ending stream of quirky pop-up galleries materialising alongside some of the world&rsquo;s finest art institutions.<br>\\r\\n&nbsp;<br>\\r\\nBut in the autumn, the capital steps things up a notch. For just a few days, Regents Park hosts one of the world&rsquo;s greatest art fairs, Frieze London, bringing together more than 160 internationally recognised galleries. This year, the event runs from 6 to 9 October," +
                    " during which time visitors can view and buy art from more than 1,000 leading artists and experience the fair&rsquo;s critically acclaimed Frieze Projects and Talks programmes.<br>\\r\\n&nbsp;<br>\\r\\nClose by, Mayfair has long been hailed as one of the city&rsquo;s most significant art hubs, with the galleries of Cork Street and the Royal Academy pulling in visitors from far and wide. Now also home to the Gagosian Gallery on Grosvenor Hill, as well as a number of specially curated sculptures and art installations, it has cemented its place as a world-renowned creative destination.<br>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><div class=\\\"grid-66 padbot\\\">\\r\\n  <img id=\\\"p_lt_ctl04_pageplaceholder_p_lt_ctl00_Image66_ucEditableImage_imgImage\\\" src=\\\"http://www.grosvenorlondon.com/news-stories/images-(1)/october-2016/mount-street%e2%80%99s-secret-art-trail/landscape1.jpg\\\" alt=\\\"Christopher Kane exhibition\\\">\\r\\n\\r\\n</div><div " +
                    "class=\\\"grid-33 norightpad padbot\\\">\\r\\n  <img id=\\\"p_lt_ctl04_pageplaceholder_p_lt_ctl00_image33a1_ucEditableImage_imgImage\\\" src=\\\"http://www.grosvenorlondon.com/news-stories/images-(1)/october-2016/mount-street%e2%80%99s-secret-art-trail/portrait1.jpg\\\" alt=\\\"Marni shopper\\\">\\r\\n\\r\\n</div><div class=\\\"box grid-33\\\">\\n  <div class=\\\"grid-parent\\\">\\n  \\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><div class=\\\"box grid-66 padbot bodyamp\\\">\\n  <div class=\\\"grid-parent\\\">\\n  Mayfair&rsquo;s Mount Street is an ideal place for art connoisseurs to head for a spot of lunch or shopping following a morning soaking up the art world&rsquo;s latest creations &ndash; whether in Regents Park or Mayfair. Many of the eponymous designers here are known for their collaborations with up-and-coming artists, or for their own personal relationship with art. Here are five that are worth paying a visit:<br>\\r\\n&nbsp;<br>\\r\\n<strong>J&amp;M " +
                    "Davidson</strong><br>\\r\\nLuxury accessories and ready-to-wear brand <a href=\\\"/directory/j-m-davidson/\\\" target=\\\"_blank\\\">J&amp;M Davidson</a>, which opened its flagship store on Mount Street in February, is known for collaborating with artists who embody its timeless style. Over the years, co-founders John and Monique have worked with fashion illustrator Tanya Ling, as well as floral artist Rebecca Louise Law, whose dried-flower installation fills the boutique&rsquo;s ground-floor ceiling.<br>\\r\\n&nbsp;<br>\\r\\n<strong>Jessica McCormack</strong><br>\\r\\nAcross the road in Carlos Place, jewellery designer <a href=\\\"/directory/jessicamccormack/\\\" target=\\\"_blank\\\">Jessica McCormack&rsquo;s boutique</a> could be described as a gallery in its own right. Alongside the designer&rsquo;s own jewellery collection, you&rsquo;ll find an incredible array of art works on display. Jessica has personally curated every aspect of the showroom, " +
                    "from her own displays to the assortment of rare and unusual objects that sit alongside the contemporary works adorning the walls.<br>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><div class=\\\"grid-66 padbot\\\">\\r\\n  <img id=\\\"p_lt_ctl04_pageplaceholder_p_lt_ctl00_Image1_ucEditableImage_imgImage\\\" src=\\\"http://www.grosvenorlondon.com/news-stories/images-(1)/october-2016/mount-street%e2%80%99s-secret-art-trail/landscape2.jpg\\\" alt=\\\"Jessica McCormack showroom\\\">\\r\\n\\r\\n</div><div class=\\\"box grid-66 padbot bodyamp\\\">\\n  <div class=\\\"grid-parent\\\">\\n  <strong>Roksanda</strong><br>\\r\\nShe may be known for her putting her stamp on London&rsquo;s fashion scene, but <a href=\\\"/directory/roksandailincic/\\\" target=\\\"_blank\\\">Roksanda Ilincic</a> actually began her design journey studying architecture and applied arts in her native Belgrade. Today, the fashion designer&rsquo;s artistic heritage shines through each of " +
                    "her collections &ndash; the Roksanda fashion house is known for its bold use of colour and unusual textiles. Her immersion in the world of art has led to impressive collaborations with a number of artists&rsquo; networks, including the Josef and Anni Albers Foundation and Studio Voltaire.<br>\\r\\n&nbsp;<br>\\r\\n<strong>Christopher Kane</strong><br>\\r\\nSince his debut in 2006, art and photography have remained a constant source of inspiration for <a href=\\\"https://www.christopherkane.com/gb\\\" target=\\\"_blank\\\">Christopher Kane</a> &ndash; as is demonstrated by last year&rsquo;s Autumn/Winter collection, based on life drawings and art therapy. Christopher&rsquo;s relationship with art was conveyed more explicitly in May this year, when the designer curated a selection of works to be displayed in his flagship store, to coincide with the Phillips Gallery Photography Sale. The exhibition included the likes of Araki, Jospeh Szabo, Robert " +
                    "Mapplethorpe and Richard Mosse.<br>\\r\\n&nbsp;<br>\\r\\n<strong>Marni</strong><br>\\r\\nAccording to the fashion brand&rsquo;s Creative Director Consuelo Castiglioni, &ldquo;<a href=\\\"http://www.marni.com/gb\\\" target=\\\"_blank\\\">Marni</a> is a range of possibilities.&rdquo; In her search for inspiration, Consuelo involves artists, both established and up-and-coming, in a range of intriguing design projects. More recently, the brand joined forces with Swedish street artist Ekta and Scottish-born painter Jack Davidson to create a range of PVC bags in eye-popping prints.<br>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><div class=\\\"grid-33 norightpad padbot\\\">\\r\\n  <img id=\\\"p_lt_ctl04_pageplaceholder_p_lt_ctl00_Image33c3_ucEditableImage_imgImage\\\" src=\\\"http://www.grosvenorlondon.com/news-stories/images-(1)/october-2016/mount-street%e2%80%99s-secret-art-trail/portrait2.jpg\\\" alt=\\\"Roksanda SS17\\\">\\r\\n\\r\\n</div>" +
                    "<hr>\\r\\n<div class=\\\"clear\\\">\\r\\n\\t&nbsp;</div>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n<script type=\\\"text/javascript\\\">\\r\\n    $(function () {\\r\\n        $('.newsletter_chronicle .button').click(function () {\\r\\n            var t = $('.newsletter_chronicle .textbox').val();\\r\\n            return t != null && t.length > 0;\\r\\n        });\\r\\n    });\\r\\n</script>\\r\\n\\n  \",\"ImageAlt\":\"Roksanda SS17\",\"ImageUrl\":\"http://www.grosvenorlondon.com/news-stories/images-(1)/october-2016/mount-street’s-secret-art-trail/portraithomepage.jpg\",\"StoryFormat\":\"LeftImage\",\"StoryId\":98,\"StoryUrl\":\"http://www.grosvenorlondon.com/News-Stories/Mount-Street’s-secret-art-trail\",\"Title\":\"Mount Street’s secret art trail\",\"VideoUrl\":\"\",\"StoryType\":\"story\",\"Location\":null,\"Description\":null,\"BuisnessName\":null,\"BuisnessContact\":null,\"ValidUntilDate\":null,\"Status\":null,\"ThemeId\":null,\"UpdatedBy\":null}],\"" +
                    "TotalNumberOfItems\":99}";
            }

            // add more response scenarious if needed. 

            if (type.ToLower() == "event")
            {
                content = "{\"Stories\":[{\"StoryStatus\":null,\"Tags\":[{\"Id\":\"177941e1-9636-446f-958b-2cb199c73023\",\"StoryId\":\"4b507aac-c7ea-40a5-893c-00079fdcb7d8\"" +
                    ",\"Tag\":\"Mayfair\"},{\"Id\":\"4ccd7cd6-4b12-4f50-bd66-795ee1ea68c4\",\"StoryId\":\"4b507aac-c7ea-40a5-893c-00079fdcb7d8\",\"Tag\":\" " +
                    "Sustainable resources \"}],\"Theme\":null,\"Id\":\"4b507aac-c7ea-40a5-893c-00079fdcb7d8\",\"Category\":\"Feature\",\"DateCreated\":\"" +
                    "2016-07-12T17:25:02\",\"DateModified\":\"2016-07-13T10:04:06.073\",\"HtmlContent\":\"\\n    <div class=\\\"grid-100 p20\\\">\\r\\n  " +
                    "<h4 style=\\\"text-align: center;\\\">\\r\\n\\tCOMMUNITY FOOTPRINT</h4>\\r\\n<h1 class=\\\"fontnewcentury\\\" style=\\\"text-align: center;\\\">\\r\\n\\tFive things that you should know about bio-bean</h1>\\r\\n<p class=\\\"headercopy\\\" style=\\\"text-align: center;\\\">\\r\\n\\tClean technology company bio-bean is set to refuel Mayfair. We sat down with its founder to learn more about the company&rsquo;s alternative, reliable and cost-effective energy supply&nbsp;</p>\\r\\n<br>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n</div><div class=\\\"grid-100 padbot\\\">\\r\\n  <img id=\\\"p_lt_ctl04_pageplaceholder_p_lt_ctl00_FullWidthImage_ucEditableImage_imgImage\\\" src=\\\"http://www.grosvenorlondon.com/news-stories/images%20(1)/july-2016/cf_bio-bean/biobean_featured.jpg\\\" alt=\\\"coffee beans\\\">\\r\\n\\r\\n</div><div class=\\\"box grid-66 padbot bodyamp\\\">\\n  <div class=\\\"grid-parent\\\">\\n  " +
                    "<strong>What&rsquo;s the outcome?</strong><br>\\r\\nThe recycling plant transforms waste coffee grounds into two different products. The first is a biomass pellet, which is used to heat places such as schools, hospitals and housing developments &ndash; anywhere with a biomass boiler.<br>\\r\\n&nbsp;<br>\\r\\nThe second product is a &lsquo;Coffee Log&rsquo; &ndash; a biomass briquette that&rsquo;s a viable sustainable alternative to wood or fossil fuels.<br>\\r\\n&nbsp;<br>\\r\\n&ldquo;There are some very exciting alternative uses that are still at the research stage,&rdquo; Kay reveals of the company&rsquo;s next steps. &ldquo;There&rsquo;s the potential to recycle coffee into biodiesel, which requires a refining stage,&rdquo; he explains. &ldquo;We&rsquo;re currently working out how best to bring that to market.&rdquo;<br>\\r\\n&nbsp;<br>\\r\\n<strong>Why coffee?</strong><br>\\r\\nCoffee " +
                    "powers our society in many respects, but when it comes to energy production, what does it have that other waste products don&rsquo;t? Kay puts its appeal down to three things. &ldquo;The first is it&rsquo;s relatively easy to collect because it&rsquo;s much less dispersed than other forms of waste,&rdquo; he says. &ldquo;The second is it&rsquo;s extremely calorific. Coffee&rsquo;s got an extremely high oil content &ndash; something like 20% in each kind of waste coffee ground &ndash; so that sets it apart because it&rsquo;s such a high energy biomass. It&rsquo;s got great potential for biofuel.<br>\\r\\n&nbsp;<br>\\r\\n&ldquo;The third is everyone drinks it, so everyone&rsquo;s quite interested in where it&rsquo;s going. For the consumer, it&rsquo;s an attractive product to work with.&rdquo;&nbsp;<br>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><div class=\\\"grid-66 padbot\\\">\\r\\n  " +
                    "<img id=\\\"p_lt_ctl04_pageplaceholder_p_lt_ctl00_Image66_ucEditableImage_imgImage\\\" src=\\\"http://www.grosvenorlondon.com/news-stories/images%20(1)/july-2016/cf_bio-bean/biobean_landscape2.jpg\\\" alt=\\\"bio-bean lab\\\">\\r\\n\\r\\n</div><div class=\\\"grid-33 norightpad padbot\\\">\\r\\n  <img id=\\\"p_lt_ctl04_pageplaceholder_p_lt_ctl00_image33a1_ucEditableImage_imgImage\\\" src=\\\"http://www.grosvenorlondon.com/news-stories/images%20(1)/july-2016/cf_bio-bean/biobean_portrait2.jpg\\\" alt=\\\"coffee\\\">\\r\\n\\r\\n</div><div class=\\\"box grid-33\\\">\\n  <div class=\\\"grid-parent\\\">\\n  \\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><div class=\\\"box grid-66 padbot bodyamp\\\">\\n  <div class=\\\"grid-parent\\\">\\n  <strong>Where do collections take place?</strong><br>\\r\\nThe business works in collaboration with First Mile, a waste-management provider that offers a simple, " +
                    "low-cost recycling service. First Mile collects waste coffee grounds on bio-bean&rsquo;s behalf and delivers the fuel source to the company.<br>\\r\\n&nbsp;<br>\\r\\n&ldquo;We made the call early on not to set up as a waste management company, because we didn&rsquo;t want to add extra vehicles and their extra emissions on the road,&rdquo; Kay explains. &ldquo;The objective for us is to have collection vehicles powered by coffee-dried biodiesel, creating an even more closed-loop solution.&rdquo;<br>\\r\\n&nbsp;<br>\\r\\nBy the end of July, the recycling service will be offered to all First Mile customers operating in Duke Street and Mount Street in Mayfair. The First Mile package will then be extended to a further five streets in the area.<br>\\r\\n&nbsp;<br>\\r\\n<strong>Who can get involved?</strong><br>\\r\\n&ldquo;We&rsquo;d love to get as many coffee-serving businesses on those streets involved " +
                    "as possible,&rdquo; says Kay. &ldquo;Despite the environmental benefits over landfill and the value associated with moving coffee further up the waste hierarchy, we wouldn&rsquo;t get through the door if we didn&rsquo;t save people money. First and foremost, this is a sustainable, commercial offering.&rdquo;<br>\\r\\n&nbsp;<br>\\r\\nVisit <a href=\\\"http://www.bio-bean.com/\\\" target=\\\"_blank\\\">bio-bean.com</a> to learn more.<br>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><div class=\\\"box grid-66 padbot bodyamp\\\">\\n  <div class=\\\"grid-parent\\\">\\n  \\r\\n\\r\\n\\r\\n\\r\\n\\n  </div>\\n</div><hr>\\r\\n<div class=\\\"clear\\\">\\r\\n\\t&nbsp;</div>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n<script type=\\\"text/javascript\\\">\\r\\n    $(function () {\\r\\n        $('.newsletter_chronicle .button').click(function () {\\r\\n            var t = $('.newsletter_chronicle .textbox').val();\\r\\n            " +
                    "return t != null && t.length > 0;\\r\\n        });\\r\\n    });\\r\\n</script>\\r\\n\\n  \",\"ImageAlt\":\"bio-bean\",\"ImageUrl\":\"http://www.grosvenorlondon.com/news-stories/images (1)/july-2016/cf_bio-bean/biobean_homepage.jpg\",\"StoryFormat\":\"TopImage\",\"StoryId\":78,\"StoryUrl\":\"http://www.grosvenorlondon.com/News-Stories/Five-things-you-should-know-about-bio-bean\",\"Title\":\"Five things you should know about bio-bean \",\"VideoUrl\":\"\",\"StoryType\":\"event\",\"Location\":null,\"Description\":null,\"BuisnessName\":null,\"BuisnessContact\":null,\"ValidUntilDate\":null,\"Status\":null,\"ThemeId\":null,\"UpdatedBy\":null},{\"StoryStatus\":null,\"Tags\":[{\"Id\":\"3f481e5a-6512-43c4-9984-0655dc999d6c\",\"StoryId\":\"57a0e2a8-7e5b-4e2a-b63f-00500ddc856b\",\"Tag\":\" Belgravia\"},{\"Id\":\"1d59b283-ee33-4189-bd34-54ef4f9afd54\",\"StoryId\":\"57a0e2a8-7e5b-4e2a-b63f-00500ddc856b\",\"Tag\":\"Retail\"}],\"Theme\":null,\"Id\":\"57a0e2a8-7e5b-4e2a-b63f-00500ddc856b\",\"Category\":\"Film\",\"DateCreated\":\"2015-10-15T14:51:40\",\"DateModified\":\"2016-01-18T15:48:13.273\",\"HtmlContent\":\"\\n    " +
                    "<div class=\\\"grid-100 p20\\\">\\r\\n  <h4 style=\\\"text-align: center;\\\">\\r\\n\\tFILM</h4>\\r\\n<h1 class=\\\"fontnewcentury\\\" style=\\\"text-align: center;\\\">\\r\\n\\tA Jewel in Belgravia&#39;s Crown</h1>\\r\\n<div style=\\\"text-align: center;\\\">\\r\\n\\tLeo and Ginnie de Vroomen have been designing and making exquisite jewellery using specialist techniques for more than 40 years. We visited their shop on Elizabeth Street to learn more about their joint venture.</div>\\r\\n<p class=\\\"headercopy\\\" style=\\\"text-align: center;\\\">\\r\\n\\t&nbsp;</p>\\r\\n&nbsp;<iframe align=\\\"middle\\\" allowfullscreen=\\\"\\\" frameborder=\\\"0\\\" height=\\\"495\\\" mozallowfullscreen=\\\"\\\" scrolling=\\\"no\\\" src=\\\"https://player.vimeo.com/video/142610182\\\" webkitallowfullscreen=\\\"\\\" width=\\\"880\\\"></iframe>\\r\\n\\r\\n\\r\\n\\r\\n</div>\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n\\r\\n<script type=\\\"text/javascript\\\">\\r\\n    $(function () {\\r\\n        $('.newsletter_chronicle .button').click(function () {\\r\\n            var t = $('.newsletter_chronicle .textbox').val();\\r\\n            " +
                    "return t != null && t.length > 0;\\r\\n        });\\r\\n    });\\r\\n</script>\\r\\n\\n  \",\"ImageAlt\":\"De Vroomen\",\"ImageUrl\":\"http://www.grosvenorlondon.com/news-stories/images (1)/october 2015/a jewel in belgravia-s crown/leodev.jpg\",\"StoryFormat\":\"TopImage\",\"StoryId\":11,\"StoryUrl\":\"http://www.grosvenorlondon.com/News-Stories/A Jewel in Belgravia-s Crown\",\"Title\":\"A Jewel in Belgravia's Crown\",\"VideoUrl\":\"\",\"StoryType\":\"event\",\"Location\":null,\"Description\":null,\"BuisnessName\":null,\"BuisnessContact\":null,\"ValidUntilDate\":null,\"Status\":null,\"ThemeId\":null,\"UpdatedBy\":null}],\"TotalNumberOfItems\":2}";
            }

            return await this.GetFakeResponse(content);
        }

        public async Task<HttpResponseMessage> GetStory(string accessToken, Guid storyId)
        {
            var content = string.Empty;
            return await this.GetFakeResponse(content);
        }
    }

}