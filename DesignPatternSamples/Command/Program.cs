using Command.ConcreteClasses;
using Command.Contracts;
using Command.ImplementationClasses;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a radio and its up/down command objects
            Radio radio = new Radio();
            radio.SwitchOn();
            IVoiceCommand volumeUpCommand = new VolumeUpCommand(radio);
            IVoiceCommand volumeDownCommand = new VolumeDownCommand(radio);

            // Create an electric window and its up/down command objects
            ElectricWindow window = new ElectricWindow();
            IVoiceCommand windowUpCommand = new WindowUpCommand(window);
            IVoiceCommand windowDownCommand = new WindowDownCommand(window);

            // Create a speech recogniser object
            SpeechRecogniser speechRecogniser = new SpeechRecogniser();
            speechRecogniser.SetCommands(volumeUpCommand, volumeDownCommand);
            Console.WriteLine("Speech recognition controlling the radio");
            speechRecogniser.HearUpSpoken();
            speechRecogniser.HearUpSpoken();
            speechRecogniser.HearUpSpoken();
            speechRecogniser.HearDownSpoken();

            speechRecogniser.SetCommands(windowUpCommand, windowDownCommand);
            Console.WriteLine("Speech recognition will now control the window");
            speechRecogniser.HearDownSpoken();
            speechRecogniser.HearUpSpoken();

            Console.Read();
        }
    }
}