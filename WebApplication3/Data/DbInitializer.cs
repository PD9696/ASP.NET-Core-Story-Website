using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.LikeList.Any())
            {
                return;
            }

            var Story1 = "ONCE upon a time there dwelled on the outskirts of a large forest a poor woodcutter with his wife and two children; the boy was called Hansel, and the girl Gretel. He always had little enough to live on, and once, when times were bad, they had to get by with one piece of bread and butter each. One night, as he was tossing about in bed, full of cares and worry, he sighed and said to his wife, 'What’s to become of us? How are we to feed our poor children, now that we have nothing more for ourselves?'\r\n \r\n  'I’ll tell you what, husband,' answered the woman, 'early tomorrow morning we’ll take the children out into the thickest part of the wood. There we shall light a fire for them and give them each a piece of bread; then we’ll go on to our work and leave them alone. They won’t be able to find their way home, and we shall be rid of them.'\r\n \r\n 'No, wife,' said her husband, 'that I won’t do; how could I find it in my heart to leave my children alone in the wood? The wild beasts would soon come and tear them to pieces.'\r\n \r\n  'Oh! You fool,' said she, 'then we must all four die of hunger, and you may just as well go and saw the boards for our coffins.' They argued and argued, until he agreed that they must get rid of Hansel and Gretel. 'But I can’t help feeling sorry for the poor children,' added the husband.\r\n \r\n  The children, too, had not been able to sleep for hunger, and had heard what their stepmother had said to their father. Gretel wept bitterly and spoke to Hansel, 'Now it’s all up with us.'\r\n \r\n  'No, no, Gretel,' said Hansel, 'don’t fret yourself; I’ll be able to find a way to escape, no fear.' When the old people had fallen asleep he got up, slipped on his little coat, opened the back door and stole out. The moon was shining clearly, and the white pebbles which lay in front of the house glittered like bits of silver. Hansel bent down and filled his pocket with as many of them as he could cram in. Then he went back and said to Gretel, 'Be comforted, my dear little sister, and go to sleep. God will not desert us,' and he lay down in bed again.\r\n \r\n  At daybreak, even before the sun was up, the woman came and woke the two children, 'Get up, you lie-abeds, we’re all going to the forest to fetch wood.' She gave them each a bit of bread and said, 'There’s something for your luncheon, but don’t you eat it up beforehand, for it’s all you’ll get.' Gretel took the bread under her apron, as Hansel had the stones in his pocket. Then they all set out together on the way to the forest. After they had walked a little, Hansel stood still and looked back at the house, and this manoeuvre he repeated again and again. His father observed him, and said, 'Hansel, what are you gazing at there? Why do you always remain behind? Take care, and don’t lose your footing.'\r\n \r\n  'Oh! father,' said Hansel, 'I am looking back at my white kitten, which is sitting on the roof, waving me a farewell.'  The woman exclaimed, 'What a donkey you are! That isn't your kitten, that’s the morning sun shining on the chimney.' But Hansel had not looked back at his kitten, but had always dropped one of the white pebbles out of his pocket on to the path.\r\n \r\n  When they had reached the middle of the forest the father said, 'Now children, go and fetch a lot of wood, and I’ll light a fire that you may not feel cold.' Hansel and Gretel heaped up brushwood until they had made a pile nearly the size of a small hill. The brushwood was set fire to, and when the flames leaped high the woman said, 'Now lie down at the fire, children, and rest yourselves: We are going into the forest to cut down wood, and when we've finished we’ll come back and fetch you.'\r\n \r\n  Hansel and Gretel sat down beside the fire, and at midday ate their little bits of bread. They heard the strokes of the axe, so they thought their father was quite near. But it was no axe they heard, but a bough he had tied on a dead tree, and that was blown about by the wind. When they had sat for a long time their eyes closed with fatigue, and they fell fast asleep. When they awoke at last, it was pitch dark. Gretel began to cry, and said, 'How are we ever to get out of the wood?'\r\n \r\n  Hansel comforted her. 'Wait a bit,' he said, 'until the moon is up, and then we’ll find our way sure enough.' When the full moon had risen, he took his sister by the hand and followed the pebbles, which shone like new threepenny bits, and showed them the path. They walked on through the night, and at daybreak reached their father’s house again. They knocked at the door, and when the woman opened it she exclaimed, 'You naughty children, what a time you've slept in the wood to! We thought you were never going to come back.' The father rejoiced, for his conscience had reproached him for leaving his children behind by themselves.\r\n \r\n  Not long afterwards there was again great dearth in the land, and the children heard their mother address their father thus in bed one night, 'Everything is eaten up once more; we have only half a loaf in the house, and when that’s gone it’s all up with us. The children must be gotten rid of; we’ll lead them deeper into the wood this time, so that they won’t be able to find their way out again. There is no other way of saving ourselves.' The man’s heart smote him heavily.\r\n \r\n  He thought, 'Surely it would be better to share the last bite with one’s children!' But his wife wouldn't listen to his arguments, and did nothing but scold and reproach him. If a man yields once, he’s done for, and so, because he had given in the first time, he was forced to do so the second.\r\n \r\n  The children were awake again, and had heard the conversation. When the old people were asleep Hansel got up, and wanted to go out and pick up pebbles again, as he had done the first time; but the woman had barred the door, and Hansel couldn't get out. But he consoled his little sister, and said, 'Don’t cry, Gretel, and sleep peacefully, for God is sure to help us.'\r\n \r\n  At early dawn the woman came and made the children get up. They received their bit of bread, but it was even smaller than the time before. On the way to the wood Hansel crumbled it in his pocket, and every few minutes he stood still and dropped a crumb on the ground. 'Hansel, what are you stopping and looking about you for?' Said the father.\r\n \r\n  'I’m looking back at my little pigeon, which is sitting on the roof waving me a farewell,' answered Hansel.\r\n \r\n  'Fool!' said the wife; 'that isn't your pigeon, it’s the morning sun glittering on the chimney.' But Hansel gradually threw all his crumbs on the path. The woman led the children still deeper into the forest farther than they had ever been in their lives before. Then a big fire was lit again, and the mother said, 'Just sit down there children, and if you’re tired you can sleep a bit; we’re going into the forest to cut down wood, and in the evening when we’re finished we’ll come back to fetch you.'\r\n \r\n  At midday Gretel divided her bread with Hansel, for he had strewn his all along their path. Then they fell asleep, evening passed away, and nobody came to the poor children. They didn’t awake until it was pitch dark, and Hansel comforted his sister, saying, 'Only wait, Gretel, 'til the moon rises, then we shall see the bread-crumbs I scattered along the path; they will show us the way back to the house.'\r\n \r\n   When the moon appeared they got up, but they found no crumbs, for the thousands of birds that fly about the woods and fields had picked them all up. 'Never mind,' said Hansel to Gretel, 'you’ll see we’ll find a way out,' but all the same they did not. They wandered about the whole night and the next day, from morning until evening, but they could not find a path out of the wood. They were very hungry too, for they had nothing to eat but a few berries they found growing on the ground. At last they were so tired that their legs refused to carry them any longer, so they lay down under a tree and fell fast asleep.\r\n \r\n  On the third morning after they had left their father’s house they set about their wandering again, but only got deeper and deeper into the wood, and now they felt that if help did not come to them soon they must perish. At midday they saw a beautiful little snow-white bird sitting on a branch, which sang so sweetly that they stopped still and listened to it. When its song was finished it flapped its wings and flew on in front of them. They followed it and came to a little house, on the roof of which it perched; and when they came quite near they saw that the cottage was made of bread and roofed with cakes, while the window was made of transparent sugar. 'Now we’ll set to,' said Hansel, 'and have a regular blow-out.I’ll eat a bit of the roof, and you, Gretel, can eat some of the window, which you’ll find a sweet morsel.' Hansel stretched up his hand and broke off a little bit of the roof to see what it was like, and Gretel went to the casement and began to nibble at it.\r\n \r\n   Thereupon a shrill voice called out from the room inside, 'Nibble, nibble, little mouse. Who’s nibbling my house?'\r\n \r\n The children answered, ''Tis heaven’s own child, the tempest wild,' and went on eating, without putting themselves about.\r\n \r\n Hansel, who thoroughly appreciated the roof, tore down a big bit of it, while Gretel pushed out a whole round window pane, and sat down the better to enjoy it. Suddenly the door opened, and an ancient dame, leaning on a staff, hobbled out. Hansel and Gretel were so terrified that they let what they had in their hands fall.\r\n \r\n  The old woman shook her head and said, 'Oh, ho! You dear children, who led you here? Just come in and stay with me, no ill shall befall you.' She took them both by the hand, led them into the house, and laid a most sumptuous dinner before them; milk and sugared pancakes, with apples and nuts. After they had finished, two beautiful little white beds were prepared for them, and when Hansel and Gretel lay down in them they felt as if they had gone to heaven.\r\n \r\n  The old woman had appeared to be most friendly, but she was really an old witch who had waylaid the children, and had only built the little bread house in order to lure them in. When anyone came into her power; she killed, cooked and ate him, and held a regular feast day for the occasion. Now witches have red eyes, and cannot see far, but like beasts, they have a keen sense of smell, and know when human beings pass by. When Hansel and Gretel fell into her hands she laughed maliciously, and said jeeringly, 'I’ve got them now; they shan't escape me.'\r\n \r\n Early in the morning, before the children were awake, she rose up, and when she saw them both sleeping so peacefully, with their round rosy cheeks, she muttered to herself, 'That’ll be a dainty bite.' Then she seized Hansel with her bony hand and carried him into a little stable, and barred the door on him. He might have screamed as much as he liked, for it would do him no good. Then she went to Gretel, shook her until she awoke, and cried, 'Get up, you lazy bones, fetch water and cook something for your brother. When he’s fat I’ll eat him up.' Gretel began to cry bitterly, but it was of no use; she had to do what the wicked witch bade her.\r\n \r\n So the best food was cooked for poor Hansel, but Gretel got nothing but crab shells. Every morning the old woman hobbled out to the stable and cried, 'Hansel, put out your finger, that I may feel if you are getting fat.' But Hansel always stretched out a bone, and the old dame, whose eyes were dim, couldn’t see it. Thinking always it was Hansel’s finger, she wondered why he fattened so slowly. When four weeks had passed and Hansel still remained thin, she lost patience and determined to wait no longer.\r\n \r\n  'Hi, Gretel,' she called to the girl, 'Be quick and get some water. Hansel may be fat or thin, I’m going to kill him tomorrow and cook him.' Oh! How the poor little sister sobbed as she carried the water, and how the tears rolled down her cheeks!\r\n \r\n 'Kind heaven help us now!' She cried. 'If only the wild beasts in the wood had eaten us, then at least we should have died together.'\r\n \r\n 'Just hold your peace,' said the old hag, 'it won’t help you.'\r\n \r\n Early in the morning, Gretel had to go out and hang up the kettle full of water, and light the fire. 'First we’ll bake,' said the old dame. 'I’ve heated the oven already and kneaded the dough.' She pushed Gretel out to the oven, from which fiery flames were already issuing. 'Creep in,' said the witch, 'and see if it’s properly heated, so that we can shove in the bread.' When she had got Gretel in she meant to close the oven and let the girl bake, that she might eat her up too. But Gretel perceived her intention, and said, 'I don’t know how I’m to do it; how do I get in?'\r\n \r\n 'You silly goose!' Said the hag. 'The opening is big enough, see, I could get in myself,' and she crawled toward it, and poked her head into the oven. Then Gretel gave her a shove that sent her right in, shut the iron door, and drew the bolt. Gracious! How she yelled; it was quite horrible, but Gretel fled and the wretched old woman was left to perish miserably.\r\n \r\n Gretel flew straight to Hansel, opened the little stable door and cried, 'Hansel, we are free; the old witch is dead!' Then Hansel sprang like a bird out of a cage when the door is opened. How they rejoiced, fell on each other’s necks, jumped for joy, and kissed one another! As they had no longer any cause for fear, they went in the old hag’s house, and here they found, in every corner of the room, boxes with pearls and precious stones. 'These are even better than pebbles,' said Hansel, and crammed his pockets full of them. Gretel said, 'I too will bring something home,' and she filled her apron full.\r\n \r\n 'Now,' said Hansel, 'let’s go and get well away from the witch’s wood.' When they had wandered about for some hours they came to a big lake. 'We can’t get over,' said Hansel, 'I see no bridge of any sort or kind.'\r\n \r\n 'Yes, and there’s no ferry boat either,' answered Gretel. 'But look, there swims a white duck. If I ask her she’ll help us over,' and she called out, 'Here are two children, mournful very, seeing neither bridge nor ferry; take us upon your white back, and row us over, quack, quack!'\r\n \r\n The duck swam towards them, and Hansel got on her back and bade his little sister sit beside him. 'No,' answered Gretel, 'we should be too heavy a load for the duck. She shall carry us across separately.' The good bird did this, and when they were landed safely on the other side, and had gone for a while, the wood became more and more familiar to them, and at length they saw their father’s house in the distance. Then they set off to run, and bounding into the room fell on their father’s neck. The man had not passed a happy hour since he left them in the wood, and the woman had died. Gretel shook out her apron so that the pearls and precious stones rolled about the room, and Hansel threw down one handful after the other out of his pocket. Thus all their troubles were ended, and they lived happily ever afterwards.\r\n \r\n Source: https://www.storynory.com/hansel-and-gretel-2/";
            double length1 = Story1.Length;
            double minutes1 = Convert.ToInt32(Math.Floor(length1 / 900));
            double seconds1 = Math.Ceiling(Math.Round(((length1 / 900) - Math.Truncate(length1 / 900)) * 60) / 10) * 10;

            var Story2 = "Once upon a time there was an old man, an old woman, and a little boy. One morning the old woman made some gingerbread in the shape of a man. She added icing for his hair and clothes, and little blobs of dough for his nose and eyes. When she put him in the oven to bake, she said to the little boy, 'You watch the gingerbread man while your grandfather and I go out to work in the garden.'\r\n \r\n So the old man and the old woman went out and began to dig potatoes, and left the little boy to tend the oven. But he started to day dream, and didn’t watch it all of the time. All of a sudden he heard a noise, and he looked up and the oven door popped open, and out of the oven jumped a gingerbread man, and went rolling along end over end towards the open door of the house. The little boy ran to shut the door, but the gingerbread man was too quick for him and rolled through the door, down the steps, and out into the road long before the little boy could catch him.\r\n \r\n The little boy ran after him as fast as he could manage, crying out to his grandfather and grandmother, who heard the noise, and threw down their spades in the garden to give chase too. The gingerbread man outran all three a long way, and was soon out of sight, while they had to sit down, all out of breath, on a bank to rest.\r\n \r\n On went the gingerbread man, and by-and-by he came to two men digging a well who looked up from their work and called out, 'Where ye going, gingerbread man?'\r\n \r\n He said, 'I’ve outrun an old man, an old woman, and a little boy - and I can outrun you too-o-o!'\r\n \r\n 'You can, can you? We’ll see about that?' Said they, and so they threw down their picks and ran after him, but couldn’t catch up with him, and soon they had to sit down by the roadside to rest.\r\n \r\n On ran the gingerbread man, and by-and-by he came to two men digging a ditch. 'Where ye going, gingerbread man?' said they.\r\n \r\n He said, 'I’ve outrun an old man, an old woman, a little boy, and two well diggers, and I can outrun you too-o-o!' 'You can, can you? We’ll see about that!' said they, and they too threw down their spades, and ran after him. The gingerbread man soon outstripped them also, and seeing they could never catch him, gave up the chase and sat down to rest.\r\n \r\n On went the gingerbread man, and by-and-by he came to a bear. The bear said, 'Where are ye going, gingerbread man?' He said, 'I’ve outrun an old man, an old woman, a little boy, two well diggers, and two ditch diggers, and I can outrun you too-o-o!'\r\n \r\n 'You can, can you?' Growled the bear. 'We’ll see about that!' He trotted as fast as his legs could carry him after the gingerbread man, who never stopped to look behind him. Before long the bear was left so far behind that he saw he might as well given up the hunt at the start, so he stretched himself out by the roadside to rest.\r\n \r\n On went the gingerbread man and by-and-by he came to a wolf. The wolf said, 'Where ye going, gingerbread man?'\r\n \r\n He said, 'I’ve outrun an old man, an old woman, a little boy, two well diggers, two ditch diggers, and a bear, and I can outrun you too-o-o!'\r\n \r\n 'You can, can you?' Snarled the wolf. 'We’ll see about that!' So he set into a gallop after the gingerbread man, who went on and on so fast, that the wolf too saw there was no hope of overtaking him, and he too lay down to rest.\r\n \r\n On went the gingerbread man, and by-and-by he came to a fox that lay quietly in a corner of the fence. The fox called out in a sharp voice, but without getting up, 'Where ye going, gingerbread man?'\r\n \r\n He said: 'I’ve outrun an old man, an old woman, a little boy, two well diggers, two ditch diggers, a bear, and a wolf, and I can outrun you too-o-o!'\r\n \r\n The fox said, 'I can’t quite hear you, gingerbread man. Won’t you come a little closer?' Turning his head a little to one side.\r\n \r\n The gingerbread man stopped his race for the first time, and went a little closer, and called out in a very loud voice, 'I’ve outrun an old man, an old woman, a little boy, two well diggers, two ditch diggers, a bear and a wolf, and I can outrun you too-o-o.'\r\n \r\n 'I still can’t quite hear you. Won’t you come a little closer?' Said the fox in a feeble voice, as he stretched out his neck towards the gingerbread man, and put one paw behind his ear.\r\n \r\n The gingerbread man came up close, and leaning towards the fox, screamed out 'I’VE OUTRUN AN OLD MAN, AN OLD WOMAN, A LITTLE BOY, TWO WELL DIGGERS, TWO DITCH DIGGERS, A BEAR AND A WOLF, AND I CAN OUTRUN YOU TOO-O-O!'\r\n \r\n 'You can, can you?' Yelped the fox, and he snapped up the gingerbread man in his sharp teeth in the twinkling of an eye.\r\n \r\n And that was the storynory of the gingerbread man. I think that the ending is rather sad, but Bertie doesn’t agree. He says that gingerbread is extremely tasty, and he doesn't blame that fox at all for wanting to eat it. I suppose he has a point, but then again, it’s not just any old piece of gingerbread that can run.\r\n \r\n Source: https://www.storynory.com/the-gingerbread-man/";
            double length2 = Story2.Length;
            double minutes2 = Convert.ToInt32(Math.Floor(length2 / 900));
            double seconds2 = Math.Ceiling(Math.Round(((length2 / 900) - Math.Truncate(length2 / 900)) * 60) / 10) * 10;

            var Story3 = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, ‘and what is the use of a book,’ thought Alice ‘without pictures or conversations?’\r\n \r\n So she was considering in her own mind (as well as she could, for the hot day made her feel very sleepy and stupid), whether the pleasure of making a daisy-chain would be worth the trouble of getting up and picking the daisies, when suddenly a White Rabbit with pink eyes ran close by her.\r\n \r\n There was nothing so VERY remarkable in that; nor did Alice think it so VERY much out of the way to hear the Rabbit say to itself, 'Oh dear! Oh dear! I shall be late!' (when she thought it over afterwards, it occurred to her that she ought to have wondered at this, but at the time it all seemed quite natural); but when the Rabbit actually TOOK A WATCH OUT OF ITS WAISTCOAT-POCKET, and looked at it, and then hurried on, Alice started to her feet, for it flashed across her mind that she had never before seen a rabbit with either a waistcoat-pocket, or a watch to take out of it, and burning with curiosity, she ran across the field after it, and fortunately was just in time to see it pop down a large rabbit-hole under the hedge.\r\n \r\n In another moment down went Alice after it, never once considering how in the world she was to get out again.\r\n \r\n The rabbit-hole went straight on like a tunnel for some way, and then dipped suddenly down, so suddenly that Alice had not a moment to think about stopping herself before she found herself falling down a very deep well.\r\n \r\n Either the well was very deep, or she fell very slowly, for she had plenty of time as she went down to look about her and to wonder what was going to happen next. First, she tried to look down and make out what she was coming to, but it was too dark to see anything; then she looked at the sides of the well, and noticed that they were filled with cupboards and book-shelves; here and there she saw maps and pictures hung upon pegs. She took down a jar from one of the shelves as she passed; it was labelled 'ORANGE MARMALADE', but to her great disappointment it was empty: she did not like to drop the jar for fear of killing somebody, so managed to put it into one of the cupboards as she fell past it.\r\n \r\n 'Well!' thought Alice to herself, 'after such a fall as this, I shall think nothing of tumbling down stairs! How brave they'll all think me at home! Why, I wouldn't say anything about it, even if I fell off the top of the house!' (Which was very likely true.)\r\n \r\n Down, down, down. Would the fall NEVER come to an end! 'I wonder how many miles I've fallen by this time?' she said aloud. 'I must be getting somewhere near the centre of the earth. Let me see: that would be four thousand miles down, I think--' (for, you see, Alice had learnt several things of this sort in her lessons in the schoolroom, and though this was not a VERY good opportunity for showing off her knowledge, as there was no one to listen to her, still it was good practice to say it over) '--yes, that's about the right distance--but then I wonder what Latitude or Longitude I've got to?' (Alice had no idea what Latitude was, or Longitude either, but thought they were nice grand words to say.)\r\n \r\n Presently she began again. 'I wonder if I shall fall right THROUGH the earth! How funny it'll seem to come out among the people that walk with their heads downward! The Antipathies, I think--' (she was rather glad there WAS no one listening, this time, as it didn't sound at all the right word) '--but I shall have to ask them what the name of the country is, you know. Please, Ma'am, is this New Zealand or Australia?' (and she tried to curtsey as she spoke--fancy CURTSEYING as you're falling through the air! Do you think you could manage it?) 'And what an ignorant little girl she'll think me for asking! No, it'll never do to ask: perhaps I shall see it written up somewhere.'\r\n \r\n Down, down, down. There was nothing else to do, so Alice soon began talking again. 'Dinah'll miss me very much to-night, I should think!' (Dinah was the cat.) 'I hope they'll remember her saucer of milk at tea-time. Dinah my dear! I wish you were down here with me! There are no mice in the air, I'm afraid, but you might catch a bat, and that's very like a mouse, you know. But do cats eat bats, I wonder?' And here Alice began to get rather sleepy, and went on saying to herself, in a dreamy sort of way, 'Do cats eat bats? Do cats eat bats?' and sometimes, 'Do bats eat cats?' for, you see, as she couldn't answer either question, it didn't much matter which way she put it. She felt that she was dozing off, and had just begun to dream that she was walking hand in hand with Dinah, and saying to her very earnestly, 'Now, Dinah, tell me the truth: did you ever eat a bat?' when suddenly, thump! thump! down she came upon a heap of sticks and dry leaves, and the fall was over.\r\n \r\n Alice was not a bit hurt, and she jumped up on to her feet in a moment: she looked up, but it was all dark overhead; before her was another long passage, and the White Rabbit was still in sight, hurrying down it. There was not a moment to be lost: away went Alice like the wind, and was just in time to hear it say, as it turned a corner, 'Oh my ears and whiskers, how late it's getting!' She was close behind it when she turned the corner, but the Rabbit was no longer to be seen: she found herself in a long, low hall, which was lit up by a row of lamps hanging from the roof.\r\n \r\n There were doors all round the hall, but they were all locked; and when Alice had been all the way down one side and up the other, trying every door, she walked sadly down the middle, wondering how she was ever to get out again.\r\n \r\n Suddenly she came upon a little three-legged table, all made of solid glass; there was nothing on it except a tiny golden key, and Alice's first thought was that it might belong to one of the doors of the hall; but, alas! either the locks were too large, or the key was too small, but at any rate it would not open any of them. However, on the second time round, she came upon a low curtain she had not noticed before, and behind it was a little door about fifteen inches high: she tried the little golden key in the lock, and to her great delight it fitted!\r\n \r\n Alice opened the door and found that it led into a small passage, not much larger than a rat-hole: she knelt down and looked along the passage into the loveliest garden you ever saw. How she longed to get out of that dark hall, and wander about among those beds of bright flowers and those cool fountains, but she could not even get her head through the doorway; 'and even if my head would go through,' thought poor Alice, 'it would be of very little use without my shoulders. Oh, how I wish I could shut up like a telescope! I think I could, if I only know how to begin.' For, you see, so many out-of-the-way things had happened lately, that Alice had begun to think that very few things indeed were really impossible.\r\n \r\n There seemed to be no use in waiting by the little door, so she went back to the table, half hoping she might find another key on it, or at any rate a book of rules for shutting people up like telescopes: this time she found a little bottle on it, ('which certainly was not here before,' said Alice,) and round the neck of the bottle was a paper label, with the words 'DRINK ME' beautifully printed on it in large letters.\r\n \r\n It was all very well to say 'Drink me,' but the wise little Alice was not going to do THAT in a hurry. 'No, I'll look first,' she said, 'and see whether it's marked 'poison' or not'; for she had read several nice little histories about children who had got burnt, and eaten up by wild beasts and other unpleasant things, all because they WOULD not remember the simple rules their friends had taught them: such as, that a red-hot poker will burn you if you hold it too long; and that if you cut your finger VERY deeply with a knife, it usually bleeds; and she had never forgotten that, if you drink much from a bottle marked 'poison,' it is almost certain to disagree with you, sooner or later.\r\n \r\n However, this bottle was NOT marked 'poison,' so Alice ventured to taste it, and finding it very nice, (it had, in fact, a sort of mixed flavour of cherry-tart, custard, pine-apple, roast turkey, toffee, and hot buttered toast,) she very soon finished it off.\r\n \r\n 'What a curious feeling!' said Alice; 'I must be shutting up like a telescope.'\r\n \r\n And so it was indeed: she was now only ten inches high, and her face brightened up at the thought that she was now the right size for going through the little door into that lovely garden. First, however, she waited for a few minutes to see if she was going to shrink any further: she felt a little nervous about this; 'for it might end, you know,' said Alice to herself, 'in my going out altogether, like a candle. I wonder what I should be like then?' And she tried to fancy what the flame of a candle is like after the candle is blown out, for she could not remember ever having seen such a thing.\r\n \r\n After a while, finding that nothing more happened, she decided on going into the garden at once; but, alas for poor Alice! when she got to the door, she found she had forgotten the little golden key, and when she went back to the table for it, she found she could not possibly reach it: she could see it quite plainly through the glass, and she tried her best to climb up one of the legs of the table, but it was too slippery; and when she had tired herself out with trying, the poor little thing sat down and cried.\r\n \r\n 'Come, there's no use in crying like that!' said Alice to herself, rather sharply; 'I advise you to leave off this minute!' She generally gave herself very good advice, (though she very seldom followed it), and sometimes she scolded herself so severely as to bring tears into her eyes; and once she remembered trying to box her own ears for having cheated herself in a game of croquet she was playing against herself, for this curious child was very fond of pretending to be two people. 'But it's no use now,' thought poor Alice, 'to pretend to be two people! Why, there's hardly enough of me left to make ONE respectable person!'\r\n \r\n Soon her eye fell on a little glass box that was lying under the table: she opened it, and found in it a very small cake, on which the words 'EAT ME' were beautifully marked in currants. 'Well, I'll eat it,' said Alice, 'and if it makes me grow larger, I can reach the key; and if it makes me grow smaller, I can creep under the door; so either way I'll get into the garden, and I don't care which happens!'\r\n \r\n She ate a little bit, and said anxiously to herself, 'Which way? Which way?', holding her hand on the top of her head to feel which way it was growing, and she was quite surprised to find that she remained the same size: to be sure, this generally happens when one eats cake, but Alice had got so much into the way of expecting nothing but out-of-the-way things to happen, that it seemed quite dull and stupid for life to go on in the common way.\r\n \r\n So she set to work, and very soon finished off the cake. Source: https://www.storynory.com/alices-adventures-in-wonderland-by-lewis-carroll/";
            double length3 = Story3.Length;
            double minutes3 = Convert.ToInt32(Math.Floor(length3 / 900));
            double seconds3 = Math.Ceiling(Math.Round(((length3 / 900) - Math.Truncate(length3 / 900)) * 60) / 10) * 10;

            var Story4 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent egestas rhoncus augue, et porta purus pharetra sed. In non accumsan lectus. Morbi dapibus augue at enim placerat mollis a vel nunc. In posuere nisl in vehicula iaculis. Donec mollis purus eget odio efficitur facilisis. Donec eget risus ex. Cras ante ex, ullamcorper condimentum pretium nec, scelerisque sed tortor. Sed placerat diam enim, sit amet rutrum sem commodo interdum. Praesent et augue sit amet risus imperdiet efficitur et eu leo. Cras vulputate erat risus, eu feugiat lectus sodales ut. Nullam ut pretium tortor, ac molestie diam. In vehicula, massa et varius venenatis, metus lectus accumsan dui, eu facilisis ex est sollicitudin sem. In at augue eget metus convallis malesuada. Vivamus et metus in sem dictum vehicula. Curabitur aliquet quam non ante egestas cursus. In ultricies maximus ligula, eget aliquam odio hendrerit hendrerit. Proin nec rhoncus libero, in rutrum massa. Suspendisse a aliquam massa. Donec quam lorem, viverra a nunc in, consequat tempus libero. Nulla at ligula eget tellus ultrices tristique. Aliquam porttitor velit ac neque feugiat sodales. In ultrices, massa sit amet sagittis maximus, odio purus aliquet dolor, elementum maximus tortor orci euismod felis. In lorem mauris, auctor at purus at, varius dictum sem. Quisque luctus non turpis nec tristique. Sed vitae congue velit, et mollis lorem. Donec id ipsum lectus. Sed elit metus, auctor et ex ut, aliquet iaculis eros. Maecenas pharetra dapibus tempor. Suspendisse faucibus libero et augue scelerisque, eu vestibulum est venenatis. Ut lacinia orci ut odio vulputate, vitae lacinia quam dapibus. Aliquam erat volutpat. Pellentesque faucibus purus purus. Quisque at aliquam nunc. Mauris fermentum ligula mauris, vitae iaculis dui euismod vel. Phasellus fringilla augue diam. Morbi venenatis sit amet nisi et pellentesque. Integer id neque orci. Quisque volutpat neque ipsum, quis mollis felis auctor ut. Duis vitae massa massa. Mauris a maximus lorem, eget pharetra sapien. Suspendisse ullamcorper id nisi eget cursus. Sed ut varius leo, ut semper dui. Fusce viverra hendrerit pretium. Sed porttitor leo at fringilla imperdiet. Donec ut varius sem. Quisque ultricies placerat laoreet. Ut tincidunt orci eu venenatis convallis. Suspendisse ac sem laoreet, lobortis eros sed, finibus magna. Etiam elementum condimentum dui, et porta massa finibus sed. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nullam sit amet bibendum felis, in mollis erat. Duis eu fermentum felis. Aenean volutpat aliquam magna eget fringilla. Donec dui diam, feugiat in nisl sit amet, feugiat gravida urna. Quisque sem mi, commodo id lorem vel, dictum pharetra justo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Vestibulum dui ex, cursus quis consequat at, placerat et velit. Cras quam velit, consectetur eget tincidunt quis, commodo in nisl. Proin porttitor sem ut orci pellentesque feugiat. Sed cursus porttitor ante, non viverra sapien dictum eget. Mauris id libero vestibulum, mattis felis et, pulvinar purus.";
            double length4 = Story4.Length;
            double minutes4 = Convert.ToInt32(Math.Floor(length4 / 900));
            double seconds4 = Math.Ceiling(Math.Round(((length4 / 900) - Math.Truncate(length4 / 900)) * 60) / 10) * 10;

            var Story5 = "Since we have not met before, I had better introduce myself properly. My name is Lapis, like the blue stone. That’s because my eyes are beautifully blue. And I am a cat. Not just any cat but a magical cat. Well to tell you the truth, I am still training to be a magical cat, but I plan to be brrrrilliant at magic one day. I live a long time before you will be born, more than two and a half thousand years before you will even be thought of. My country is Egypt but I am told that you will call it Ancient Egypt.\r\n \r\n I am here to tell you stories. The subject of my tales is eternally fascinating. They are all about ME!\r\n \r\n What’s that? Someone is asking how it is that if I am truly ancient Egyptian, that you can hear my voice? Should I not be a mummified cat by now? Shouldn’t my stories have been written in pretty picture words called hieroglyphics, inscribed on scrolls of papyrus, torn by time into thousands of teeny shreds, and blown around by the African winds along with the sands of the desert?\r\n \r\n Well it is a good question. Yes I live a long time before you, and Amon the priest-scribe does write down my stories, and being a skilled magician, naturally he uses magical talking letters. That’s how I can speak to you directly down the millennia.\r\n \r\n What’s that you are saying now?\r\n \r\n Is “millennia” a word?\r\n \r\n Oh, so you are asking me, an ancient Egyptian Cat, to explain English to you now, are you? Well little one, the perfectly good word, ‘millennia’ means ‘thousands of years.’\r\n \r\n You kids of the future think that we couldn’t do anything without your “modern” technology. Yes technology is sort of smart but let me tell you - it is nothing compared to magic of the past. And the most magical time and place ever was in Per-Bast on the river Nile.\r\n \r\n Some people will tell you that Memphis is the capital of magic. And yes it is for humans. But the cat capital of Egypt Is Per-Bast. And it is far more magical than Memphis. As even you Kids of the future probably know, we cats are the most magical creatures of all. Magic comes to us naturally. You humans might try for years to make yourself invisible. A few especially talented individuals will succeed - eventually. But we cats, if we have a good teacher, can learn to do such things in under a year.\r\n \r\n I’m still learning my magical lessons, but Amon the priest believes in me. Here at Per-Bast I have thousands of sisters and brothers. We cats call each other sister or brother even if strictly we aren’t from the same parents. The steps of the temple are literally crawling with cute kitties, scraggy strays, and sly bandit cats. But Amon says that The Cat Goddess, Lady Bastet, picked me out. She said to Amon, “There are as many cats with green eyes as there are grains of sand in the desert, but this gorgeous little kitty has blue eyes, and she is a chosen cat. She stands apart from all the others with her great beauty. You must train her up to honour me by performing wondrous magic.”\r\n \r\n That means I am a special cat.\r\n \r\n I’m sacred.\r\n \r\n If anyone harms me, they’re in for it. Divine retribution will follow swiftly.\r\n \r\n One day I shall by mummified and my spirit shall travel to the kingdom of the past cats. But I don’t want that to happen too soon, thanks. I’m having a nice time in this world. So if anyone is thinking of becoming my enemy, listen up: I’ve got friends in high places. Amon the priest, and Lady Bastet the cat goddess, are my friends, sponsors and protectors. Harm me and you shall have to answer to them.\r\n \r\n Let me give you an example of what I mean. There’s a priest at the temple called Simon the Greek - he got that name because he was born in Greece and came to Egypt when he was a boy. Simon the Greek does not even like cats - so what is he doing here at Per-Bast, the temple of cats you may ask? He’s in the wrong job. But presumably it pays him well so he stays. But he hates cats, unless they are mummified, so he sells them to the pilgrims as souvenirs.\r\n \r\n One time, when I was asleep, stretched out in the sun on a step outside his office, he gave me an almighty kick. It was a vicious enough swing of his leg to break a few ribs or even to kill a cat. But Bastet the cat goddess was watching over me, and she made his foot miss my side. Instead of booting me, he stubbed his toe on the stone step. How he howled and hopped about with pain! MEEEEEOW! That’s what comes of messing with me, Lapis, the favoured cat of Bastet and her high priest, Amon.\r\n \r\n But right now, I am not entirely sure that I am in Amon’s good books. He seems a bit cross with me.\r\n \r\n You see, he wants me to learn my magic faster. But it is not easy and I can only do my best.\r\n \r\n A few days ago, he picked me up in his big hands and looked directly into my blue eyes. I didn’t like that. It was kind of scary.\r\n \r\n ‘Listen, Lapis,’ he said, ‘Bastet told me in a dream that you are a chosen cat. But I am starting to wonder if it was a false dream that I saw. I have been teaching you for six solid weeks now, and you have made almost no progress. You can not even magic a mouse to stand still. If it was not for the words of Bastet in that dream, I would put you down as a lazy little feline. But Bastet is a great goddess and she knows better than I do. So here is what I’ve got to say. You learn your lesson well today, and you will receive a nice reward. I will have a solid gold earring made for you. It means getting your ears pierced, which might hurt a little, but after that you will have a pretty piece of jewellery to wear all your life, and to take later to the world of the cats on the other side of the dark river. You would like that wouldn’t you?’\r\n \r\n Meeow! I said. Of course I would like a solid gold earing. It will make me even more beautiful and distinguished than I am already.\r\n \r\n My lesson was to learn the spell for turning Natron Salt into toothpaste - a handy domestic trick and a profitable one too because the priests sell it as a sideline. Pilgrims are usually in a jolly mood when they come to the cat temple, and they are ready to buy gifts to take home to their family. A pot of our famous Luxury Natron Toothpaste is a popular choice. It’s not just for teeth, you know. It can also be used for shaving foam, or for exfoliating lady’s skin, and at a pinch you can use it to embalm a relative. The priests sell it at a fancy price in the shop by the temple.\r\n \r\n Amon showed me how to wave the magic sign with my paw, and left me with 10 sacks of Natron - a valuable stock. I set to my work. My task was to have it all packaged up in smart little earthenware pots bearing a pretty symbol of our cat goddess, Bastet.\r\n \r\n I tried waving my paw and swishing my tail like it said in the magic book. Nothing happened. I tell you, this magic business is not as easy as it looks. It takes loads of practice.\r\n \r\n So, I went for a walk by the river to see if I could find some fish. When I dipped a paw in the water, an old crocodile snapped at me. SCREEECH! I scuttled back home in a somewhat nervous state before I and had another go at the paw waving magic. And this time it worked - or so I thought,\r\n \r\n When Amon returned that evening and found rows of pretty pots full of toothpaste he was well pleased with me. He fried a large piece of fish for my supper and promised me the gold earring as soon as the temple’s goldsmith could get one ready.\r\n \r\n But that was before anyone tried the toothpaste. Last night, he came back from work in not a pretty mood.\r\n \r\n ‘We sold 12 pots of the toothpaste you made,’ he said.\r\n \r\n I rubbed myself up against his leg.\r\n \r\n ‘One of the customers was a princess,’ he went on.\r\n \r\n ‘PRRRRRRRRR!’ I replied with pride.\r\n \r\n ‘Don’t purr me!’ said Amon. ‘She’s furious, Her teeth have turned black and her breath smells of rotten fish!’\r\n \r\n ‘That’s toooo bad,’ I said, ‘But don’t blame me. The Natron salt must have gone off! You know, you can’t leave fish in the sun for long, because it will start to sink. It’s the same with salt, I’m afraid.’\r\n \r\n ‘That’s the stupidest excuse I ever heard’ he shouted, ‘ Salt doesn’t go off. It’s you that’s a lazy, careless cat, who doesn’t learn her lessons!’\r\n \r\n He was waving a finger at me, quite agitated, and I feared that he might do me some harm.\r\n \r\n ‘Now, now, don’t forget, I’m a favourite cat of the goddess,’ I reminded him.\r\n \r\n But Amon hurled a pot of toothpaste In my direction. Of course it missed me, because the goddess protects me, but I thought it would be wise to make myself scarce while he calmed down and saw sense. I sprang through the window and found a shady spot on the other side of the temple where I could hide out for a while.\r\n \r\n I will slink back in the morning. I hope the goddess will tell him in a dream to be patient with me. I might be a slow learner but I am destined for great things. You shall all see!\r\n \r\n Source: https://www.storynory.com/lapis-the-egyptian-cat/";
            double length5 = Story5.Length;
            double minutes5 = Convert.ToInt32(Math.Floor(length5 / 900));
            double seconds5 = Math.Ceiling(Math.Round(((length5 / 900) - Math.Truncate(length5 / 900)) * 60) / 10) * 10;

            var Story6 = "Hello. Goodbye. The end.";
            double length6 = Story6.Length;
            double minutes6 = Convert.ToInt32(Math.Floor(length6 / 900));
            double seconds6 = Math.Ceiling(Math.Round(((length6 / 900) - Math.Truncate(length6 / 900)) * 60) / 10) * 10;

            var Story7 = "It was a large lovely garden, with soft green grass. Here and there over the grass stood beautiful flowers like stars, and there were twelve peach-trees that in the spring-time broke out into delicate blossoms of pink and pearl, and in the autumn bore rich fruit. The birds sat on the trees and sang so sweetly that the children used to stop their games in order to listen to them. 'How happy we are here!' they cried to each other.\r\n \r\n One day the Giant came back. He had been to visit his friend the Cornish ogre, and had stayed with him for seven years. After the seven years were over he had said all that he had to say, for his conversation was limited, and he determined to return to his own castle. When he arrived he saw the children playing in the garden.\r\n \r\n 'What are you doing here?' he cried in a very gruff voice, and the children ran away.\r\n \r\n 'My own garden is my own garden,' said the Giant; 'any one can understand that, and I will allow nobody to play in it but myself.' So he built a high wall all round it, and put up a notice-board.\r\n \r\n TRESPASSERS WILL BE PROSECUTED\r\n \r\n He was a very selfish Giant.\r\n \r\n The poor children had now nowhere to play. They tried to play on the road, but the road was very dusty and full of hard stones, and they did not like it. They used to wander round the high wall when their lessons were over, and talk about the beautiful garden inside. 'How happy we were there,' they said to each other.\r\n \r\n Then the Spring came, and all over the country there were little blossoms and little birds. Only in the garden of the Selfish Giant it was still winter. The birds did not care to sing in it as there were no children, and the trees forgot to blossom. Once a beautiful flower put its head out from the grass, but when it saw the notice-board it was so sorry for the children that it slipped back into the ground again, and went off to sleep. The only people who were pleased were the Snow and the Frost. 'Spring has forgotten this garden,' they cried, 'so we will live here all the year round.' The Snow covered up the grass with her great white cloak, and the Frost painted all the trees silver. Then they invited the North Wind to stay with them, and he came. He was wrapped in furs, and he roared all day about the garden, and blew the chimney-pots down. 'This is a delightful spot,' he said, 'we must ask the Hail on a visit.' So the Hail came. Every day for three hours he rattled on the roof of the castle till he broke most of the slates, and then he ran round and round the garden as fast as he could go. He was dressed in grey, and his breath was like ice.\r\n \r\n 'I cannot understand why the Spring is so late in coming,' said the Selfish Giant, as he sat at the window and looked out at his cold white garden; 'I hope there will be a change in the weather.'\r\n \r\n But the Spring never came, nor the Summer. The Autumn gave golden fruit to every garden, but to the Giant's garden she gave none. 'He is too selfish,' she said. So it was always Winter there, and the North Wind, and the Hail, and the Frost, and the Snow danced about through the trees.\r\n \r\n One morning the Giant was lying awake in bed when he heard some lovely music. It sounded so sweet to his ears that he thought it must be the King's musicians passing by. It was really only a little linnet singing outside his window, but it was so long since he had heard a bird sing in his garden that it seemed to him to be the most beautiful music in the world. Then the Hail stopped dancing over his head, and the North Wind ceased roaring, and a delicious perfume came to him through the open casement. 'I believe the Spring has come at last,' said the Giant; and he jumped out of bed and looked out.\r\n \r\n What did he see?\r\n \r\n He saw a most wonderful sight. Through a little hole in the wall the children had crept in, and they were sitting in the branches of the trees. In every tree that he could see there was a little child. And the trees were so glad to have the children back again that they had covered themselves with blossoms, and were waving their arms gently above the children's heads. The birds were flying about and twittering with delight, and the flowers were looking up through the green grass and laughing. It was a lovely scene, only in one corner it was still winter. It was the farthest corner of the garden, and in it was standing a little boy. He was so small that he could not reach up to the branches of the tree, and he was wandering all round it, crying bitterly. The poor tree was still quite covered with frost and snow, and the North Wind was blowing and roaring above it. 'Climb up! little boy,' said the Tree, and it bent its branches down as low as it could; but the boy was too tiny.\r\n \r\n And the Giant's heart melted as he looked out. 'How selfish I have been!' he said; 'now I know why the Spring would not come here. I will put that poor little boy on the top of the tree, and then I will knock down the wall, and my garden shall be the children's playground for ever and ever.' He was really very sorry for what he had done.\r\n \r\n So he crept downstairs and opened the front door quite softly, and went out into the garden. But when the children saw him they were so frightened that they all ran away, and the garden became winter again. Only the little boy did not run, for his eyes were so full of tears that he did not see the Giant coming. And the Giant stole up behind him and took him gently in his hand, and put him up into the tree. And the tree broke at once into blossom, and the birds came and sang on it, and the little boy stretched out his two arms and flung them round the Giant's neck, and kissed him. And the other children, when they saw that the Giant was not wicked any longer, came running back, and with them came the Spring. 'It is your garden now, little children,' said the Giant, and he took a great axe and knocked down the wall. And when the people were going to market at twelve o'clock they found the Giant playing with the children in the most beautiful garden they had ever seen.\r\n \r\n All day long they played, and in the evening they came to the Giant to bid him good-bye.\r\n \r\n 'But where is your little companion?' he said: 'the boy I put into the tree.'\r\n \r\n 'We don't know,' answered the children; 'he has gone away.' 'You must tell him to be sure and come here to-morrow,' said the Giant. But the children said that they did not know where he lived, and had never seen him before; and the Giant felt very sad.\r\n \r\n Every afternoon, when school was over, the children came and played with the Giant. But the little boy whom the Giant loved was never seen again. The Giant was very kind to all the children, yet he longed for his first little friend, and often spoke of him. 'How I would like to see him!' he used to say.\r\n \r\n Years went over, and the Giant grew very old and feeble. He could not play about any more, so he sat in a huge armchair, and watched the children at their games, and admired his garden. 'I have many beautiful flowers,' he said; 'but the children are the most beautiful flowers of all.'\r\n \r\n One winter morning he looked out of his window as he was dressing. He did not hate the Winter now, for he knew that it was merely the Spring asleep, and that the flowers were resting.\r\n \r\n Suddenly he rubbed his eyes in wonder, and looked and looked. It certainly was a marvelous sight. In the farthest corner of the garden was a tree quite covered with lovely white blossoms. Its branches were all golden, and silver fruit hung down from them, and underneath it stood the little boy he had loved.\r\n \r\n Downstairs ran the Giant in great joy, and out into the garden. He hastened across the grass, and came near to the child. And when he came quite close his face grew red with anger, and he said, 'Who hath dared to wound thee?' For on the palms of the child's hands were the prints of two nails, and the prints of two nails were on the little feet.\r\n \r\n 'Who hath dared to wound thee?' cried the Giant; 'tell me, that I may take my big sword and slay him.'\r\n \r\n 'Nay!' answered the child; 'but these are the wounds of Love.'\r\n \r\n 'Who art thou?' said the Giant, and a strange awe fell on him, and he knelt before the little child.\r\n \r\n And the child smiled on the Giant, and said to him, 'You let me play once in your garden, to-day you shall come with me to my garden, which is Paradise.'\r\n \r\n And when the children ran in that afternoon, they found the Giant lying dead under the tree, all covered with white blossoms.\r\n \r\n Source: https://www.storynory.com/the-selfish-giant/";
            double length7 = Story7.Length;
            double minutes7 = Convert.ToInt32(Math.Floor(length7 / 900));
            double seconds7 = Math.Ceiling(Math.Round(((length7 / 900) - Math.Truncate(length7 / 900)) * 60) / 10) * 10;

            var users = new ApplicationUser[]
            {
                new ApplicationUser
                {
                    Id = "a",
                    Email = "a@a.com",
                    NormalizedEmail = "A@A.COM",
                    EmailConfirmed = false,
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                    UserName = "a@a.com",
                    NormalizedUserName = "A@A.COM"
                },

                new ApplicationUser
                {
                    Id = "b",
                    Email = "b@b.com",
                    NormalizedEmail = "B@B.COM",
                    EmailConfirmed = false,
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                    UserName = "b@b.com",
                    NormalizedUserName = "B@B.COM"
                },

                new ApplicationUser
                {
                    Id = "c",
                    Email = "c@c.com",
                    NormalizedEmail = "C@C.COM",
                    EmailConfirmed = false,
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                    UserName = "c@c.com",
                    NormalizedUserName = "C@C.COM"
                },

                new ApplicationUser
                {
                    Id = "d",
                    Email = "d@d.com",
                    NormalizedEmail = "D@D.COM",
                    EmailConfirmed = false,
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                    UserName = "d@d.com",
                    NormalizedUserName = "D@D.COM"
                },

                new ApplicationUser
                {
                    Id = "e",
                    Email = "e@e.com",
                    NormalizedEmail = "E@E.COM",
                    EmailConfirmed = false,
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                    UserName = "e@e.com",
                    NormalizedUserName = "E@E.COM"
                }
            };

            var password = new PasswordHasher<ApplicationUser>();
            foreach (ApplicationUser user in users)
            {
                user.PasswordHash = password.HashPassword(user, "P@ssword1");
                context.Users.Add(user);
            }
            context.SaveChanges();

            var profiles = new Profile[]
            {
                new Profile
                {
                    UserName = "John",
                    OwnerId = "a",
                    QuickDescription = "I like to write funny stories",
                    Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed turpis elit, mollis bibendum consectetur vel, vehicula vitae urna. Integer congue lectus eros, ut dignissim lectus ornare eu. Integer posuere ex eget vestibulum pulvinar. Fusce sem leo, scelerisque in suscipit porta, malesuada malesuada turpis. Suspendisse gravida non odio id molestie. Aenean efficitur fringilla porttitor. Nulla facilisi. Nunc dolor diam, malesuada id ultricies vel, fermentum id libero. Duis orci felis, iaculis vitae sodales in, luctus in tortor. Quisque eu pellentesque mi. Nunc nec pellentesque leo. Mauris a lorem a lectus imperdiet commodo. Aenean quis dictum ante. Curabitur vel mattis nunc.",
                    Followers = 3,
                    CreationDate = DateTime.Parse("2017-9-29")
                },

                new Profile
                {
                    UserName = "Creative Stacy",
                    OwnerId = "b",
                    QuickDescription = "I write very creative stories",
                    Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer ac dolor sollicitudin, vulputate sapien in, posuere magna. In ac sem non diam viverra sollicitudin eget vel arcu. Nullam eu semper urna. Nulla bibendum condimentum sapien id eleifend. Sed id libero hendrerit, elementum ipsum in, varius ligula. Vestibulum tempus aliquam augue ac dictum. Nulla semper vestibulum turpis, semper pretium nibh. Integer et nulla velit. Pellentesque at sapien eleifend mi dapibus faucibus. Donec commodo erat odio, in semper nibh ultricies non. Maecenas dolor odio, commodo eu venenatis nec, condimentum in nisl. Cras mattis odio pulvinar leo rutrum, sit amet tempus ipsum vulputate. Vestibulum volutpat odio vitae luctus pharetra.",
                    Followers = 4,
                    CreationDate = DateTime.Parse("2018-6-12")
                },

                new Profile
                {
                    UserName = "mythXwriter",
                    OwnerId = "c",
                    QuickDescription = "I am a student of mythology",
                    Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi a ex vitae arcu ultricies pharetra sit amet vitae ligula. Ut ultricies justo in pellentesque elementum. Donec porta, libero sit amet maximus sodales, odio nisl ullamcorper nunc, et vulputate diam metus et erat. Donec rhoncus tortor erat, nec maximus diam ultricies vel. Maecenas tempus porttitor justo eu tristique. Sed mauris neque, pellentesque eget rhoncus et, varius vitae turpis. Etiam maximus posuere ex, quis lobortis justo. Donec eget bibendum mauris, ut sagittis metus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. In placerat placerat risus, a accumsan magna sollicitudin in. Donec a ipsum mi. Vivamus in elit velit. Integer id massa ut nisl ullamcorper tristique eu sed enim. Donec rhoncus tempus elit, elementum auctor dui.",
                    Followers = 2,
                    CreationDate = DateTime.Parse("2019-1-15")
                },

                new Profile
                {
                    UserName = "SuperTom7",
                    OwnerId = "d",
                    QuickDescription = "The best writer on this website!",
                    Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris elementum quam nec nunc convallis luctus. Sed porta sagittis est, vel accumsan justo egestas et. Nullam turpis nisl, tempor et aliquet eget, gravida in urna. Proin ut venenatis enim, ac cursus ipsum. Vestibulum blandit nunc ut justo viverra molestie. Duis tincidunt, lectus sodales elementum egestas, mauris eros congue velit, et congue mauris ligula quis risus. Integer venenatis vitae sapien et scelerisque.",
                    Followers = 0,
                    CreationDate = DateTime.Parse("2017-3-20")
                },

                new Profile
                {
                    UserName = "Reader4",
                    OwnerId = "e",
                    QuickDescription = "I don't write stories, I only read them",
                    Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent eu nisl dolor. Donec mattis turpis ut tortor maximus semper. Curabitur ut leo justo. Pellentesque dignissim leo nunc, et placerat neque rhoncus vel. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Ut imperdiet ante vel nulla luctus, et faucibus tellus sodales. Sed elit metus, faucibus at condimentum vitae, bibendum ac ante. Aliquam erat volutpat. Cras sagittis turpis sit amet arcu malesuada pellentesque. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Curabitur lacus eros, mattis vel tempus et, auctor at ligula. Nam at consequat mi. Maecenas fringilla nisl ut mi consequat euismod. Morbi sit amet euismod dui. Proin dui elit, condimentum et orci nec, pulvinar tempus nunc. Donec vitae mauris quis est fringilla fermentum eu sit amet lectus.",
                    Followers = 1,
                    CreationDate = DateTime.Parse("2019-3-7")
                }
            };

            foreach (Profile profile in profiles)
            {
                context.Profile.Add(profile);
            }
            context.SaveChanges();

            int[] profileIds = new int[5];
            int i = 0;
            foreach (Profile profile in profiles)
            {
                profileIds[i] = profile.Id;
                i++;
            }

            i = 0;
            foreach (ApplicationUser user in users)
            {
                user.ProfileId = profileIds[i];
                i++;
            }

            var stories = new Story[]
            {
                new Story
                    {
                        ProfileId = profileIds[0],
                        Likes = 2,
                        Title = "Hansel and Gretel",
                        Content = Story1,
                        Author = "John",
                        IsEdited = false,
                        EstimatedLength = (int)minutes1,
                        CreationDate = DateTime.Parse("2017-10-29"),
                        Genre = "Horror",
                        EstimatedLengthSeconds = (int)seconds1
                    },

                    new Story
                    {
                        ProfileId = profileIds[3],
                        Likes = 0,
                        Title = "Lorem Ipsum",
                        Content = Story4,
                        Author = "SuperTom7",
                        IsEdited = false,
                        EstimatedLength = (int)minutes4,
                        CreationDate = DateTime.Parse("2019-3-10"),
                        Genre = "Classic",
                        EstimatedLengthSeconds = (int)seconds4
                    },

                    new Story
                    {
                        ProfileId = profileIds[2],
                        Likes = 1,
                        Title = "Alice in Wonderland",
                        Content = Story3,
                        Author = "mythXwriter",
                        IsEdited = true,
                        EstimatedLength = (int)minutes3,
                        CreationDate = DateTime.Parse("2019-2-20"),
                        Genre = "Fantasy",
                        EstimatedLengthSeconds = (int)seconds3,
                        EditDate = DateTime.Parse("2019-3-10")
                    },

                    new Story
                    {
                        ProfileId = profileIds[1],
                        Likes = 4,
                        Title = "The Gingerbread Man",
                        Content = Story2,
                        Author = "Creative Stacy",
                        IsEdited = true,
                        EstimatedLength = (int)minutes2,
                        CreationDate = DateTime.Parse("2018-12-18"),
                        Genre = "Classic",
                        EstimatedLengthSeconds = (int)seconds2,
                        EditDate = DateTime.Parse("2019-3-1")
                    },

                    new Story
                    {
                        ProfileId = profileIds[1],
                        Likes = 2,
                        Title = "Lapis the Egyption Cat",
                        Content = Story5,
                        Author = "Creative Stacy",
                        IsEdited = false,
                        EstimatedLength = (int)minutes5,
                        CreationDate = DateTime.Parse("2018-7-10"),
                        Genre = "Mythology",
                        EstimatedLengthSeconds = (int)seconds5
                    },

                    new Story
                    {
                        ProfileId = profileIds[2],
                        Likes = 1,
                        Title = "Very Short",
                        Content = Story6,
                        Author = "mythXwriter",
                        IsEdited = false,
                        EstimatedLength = (int)minutes6,
                        CreationDate = DateTime.Parse("2019-3-1"),
                        Genre = "Comedy",
                        EstimatedLengthSeconds = (int)seconds6
                    },

                    new Story
                    {
                        ProfileId = profileIds[0],
                        Likes = 3,
                        Title = "The Selfish Giant",
                        Content = Story7,
                        Author = "John",
                        IsEdited = false,
                        EstimatedLength = (int)minutes7,
                        CreationDate = DateTime.Now,
                        Genre = "Fable",
                        EstimatedLengthSeconds = (int)seconds7
                    }
            };

            foreach (Story story in stories)
            {
                context.Story.Add(story);
            }
            context.SaveChanges();

            int[] storyIds = new int[7];
            i = 0;
            foreach (Story story in stories)
            {
                storyIds[i] = story.Id;
                i++;
            }

            var followerlists = new FollowerList[]
            {
                new FollowerList
                    {
                        ProfileId = profileIds[0],
                        FollowerId = profileIds[1]
                    },

                    new FollowerList
                    {
                        ProfileId = profileIds[0],
                        FollowerId = profileIds[2]
                    },

                    new FollowerList
                    {
                        ProfileId = profileIds[0],
                        FollowerId = profileIds[4]
                    },

                    new FollowerList
                    {
                        ProfileId = profileIds[1],
                        FollowerId = profileIds[0]
                    },

                    new FollowerList
                    {
                        ProfileId = profileIds[1],
                        FollowerId = profileIds[2]
                    },

                    new FollowerList
                    {
                        ProfileId = profileIds[1],
                        FollowerId = profileIds[3]
                    },

                    new FollowerList
                    {
                        ProfileId = profileIds[1],
                        FollowerId = profileIds[4]
                    },

                    new FollowerList
                    {
                        ProfileId = profileIds[2],
                        FollowerId = profileIds[0]
                    },

                    new FollowerList
                    {
                        ProfileId = profileIds[2],
                        FollowerId = profileIds[4]
                    },

                    new FollowerList
                    {
                        ProfileId = profileIds[4],
                        FollowerId = profileIds[3]
                    }
            };

            foreach (FollowerList followerlist in followerlists)
            {
                context.FollowerList.Add(followerlist);
            }
            context.SaveChanges();

            var likelists = new LikeList[]
            {
                new LikeList
                    {
                        ProfileId = profileIds[4],
                        StoryId = storyIds[0]
                    },

                    new LikeList
                    {
                        ProfileId = profileIds[3],
                        StoryId = storyIds[0]
                    },

                    new LikeList
                    {
                        ProfileId = profileIds[2],
                        StoryId = storyIds[2]
                    },

                    new LikeList
                    {
                        ProfileId = profileIds[1],
                        StoryId = storyIds[3]
                    },

                    new LikeList
                    {
                        ProfileId = profileIds[0],
                        StoryId = storyIds[3]
                    },

                    new LikeList
                    {
                        ProfileId = profileIds[4],
                        StoryId = storyIds[3]
                    },

                    new LikeList
                    {
                        ProfileId = profileIds[3],
                        StoryId = storyIds[3]
                    },

                    new LikeList
                    {
                        ProfileId = profileIds[2],
                        StoryId = storyIds[4]
                    },

                    new LikeList
                    {
                        ProfileId = profileIds[1],
                        StoryId = storyIds[4]
                    },

                    new LikeList
                    {
                        ProfileId = profileIds[0],
                        StoryId = storyIds[5]
                    },

                    new LikeList
                    {
                        ProfileId = profileIds[4],
                        StoryId = storyIds[6]
                    },

                    new LikeList
                    {
                        ProfileId = profileIds[3],
                        StoryId = storyIds[6]
                    },

                    new LikeList
                    {
                        ProfileId = profileIds[2],
                        StoryId = storyIds[6]
                    }
            };

            foreach(LikeList likelist in likelists)
            {
                context.LikeList.Add(likelist);
            }
            context.SaveChanges();
        }
    }
}