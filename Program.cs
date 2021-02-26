using System;
using System.Threading;

Main();

void Main()
{
  Console.WriteLine("Welcome to the Magic Moose's Moose Hoose!");
  Console.WriteLine("-----------------------------------------");
  QuestionPrompt();
}

void QuestionPrompt()
{
  Console.Write("Ask the moose a question! ");
  string question = Console.ReadLine();
  if (string.IsNullOrWhiteSpace(question))
  {
    MooseSays("Bye!");
  }
  else
  {
    MooseSays(MooseAnswer());
    Thread.Sleep(3000);
    Console.Clear();
    QuestionPrompt();
  }
}

string MooseAnswer()
{
  int randNum = new Random().Next(1, 18);
  string answer = "Unknown";
  switch (randNum)
  {
    case 1:
      answer = "As I see it, yes.";
      break;
    case 2:
      answer = "Ask again later.";
      break;
    case 3:
      answer = "Better not tell you now.";
      break;
    case 4:
      answer = "Cannot predict now.";
      break;
    case 5:
      answer = "Concentrate and ask again.";
      break;
    case 6:
      answer = "It is certain.";
      break;
    case 7:
      answer = "It is decidedly so.";
      break;
    case 8:
      answer = "Most likely.";
      break;
    case 9:
      answer = "My reply is no.";
      break;
    case 10:
      answer = "My sources say no.";
      break;
    case 11:
      answer = "Outlook not so good.";
      break;
    case 12:
      answer = "Outlook good.";
      break;
    case 13:
      answer = "Reply hazy, try again.";
      break;
    case 14:
      answer = "Signs point to yes.";
      break;
    case 15:
      answer = "Very doubtful.";
      break;
    case 16:
      answer = "Without a doubt.";
      break;
    case 17:
      answer = "Yes.";
      break;
    case 18:
      answer = "Yes – definitely.";
      break;
  }
  return answer;
}

void MooseSays(string message)
{
  Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    
    
    ");
}
