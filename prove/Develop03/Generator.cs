public class Generator
{
 public Scripture ReturnScripture()
 {
  List<Scripture> scriptures = new List<Scripture>();
  scriptures.Add(new Scripture("Genesis", 1, 1, new Reference("In the beginning God created the heaven and the earth.")));
  scriptures.Add(new Scripture("Genesis", 1, 2, new Reference("And the earth was without form, and void; and darkness was upon the face of the deep. And the Spirit of God moved upon the face of the waters.")));
  scriptures.Add(new Scripture("Genesis", 1, 3, new Reference("And God said, Let there be light: and there was light.")));
  scriptures.Add(new Scripture("Luke", 2, 10, 12, new Reference("And the angel said unto them, Fear not: for, behold, I bring you good tidings of great joy, which shall be to all people. For unto you is born this day in the city of David a Saviour, which is Christ the Lord. And this shall be a sign unto you; Ye shall find the babe wrapped in swaddling clothes, lying in a manger.")));

  Random random = new Random();
  int randomNumber = random.Next(0, scriptures.Count);
  return scriptures[randomNumber];
 }
}