﻿using DSharpPlus.CommandsNext;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace SilverBotDS.Objects
{
    //TODO finish the summaries and shiz
    //I know i promised language support but im kinda of an idiot so yeah
    public partial class Language
    {
        /// <summary>
        /// Default(EN)
        /// </summary>
        public string LangName { get; set; } = "English(EN)";

        /// <summary>
        /// A 2-4 alphanumeric code
        /// </summary>
        public string LangCodeGoogleTranslate { get; set; } = "en";

        /// <summary>
        /// <b>Hi </b>@max<b>!</b>
        /// <para/>
        /// <b>Hi␣</b>{0}<b>!</b>
        /// </summary>
        /// <remarks>
        /// Needs to be used like <c>String.Format(Language.Hi,Username);</c>
        /// </remarks>
        public string Hi { get; set; } = "Hi {0}!";

        /// <summary>
        /// <b>Time in UTC is </b>01.1.2021 17:20:28
        /// <para/>
        /// <b>Time␣in␣UTC is␣</b>{0}
        /// </summary>
        /// <remarks>
        /// Needs to be used like <c>String.Format(Language.Time_In_Utc,DateTime.NowUTC.ToString(Language.Time_format));</c>
        /// </remarks>
        public string TimeInUtc { get; set; } = "Time in UTC is {0}";

        /// <summary>
        /// This command is disabled
        /// </summary>
        public string CommandIsDisabled { get; set; } = "This command is disabled";

        /// <summary>
        /// <b>Requested by </b>SilverDimond
        /// <para/>
        /// <b>Requested␣by␣</b>
        /// </summary>
        /// <remarks>
        /// Needs to be used like <c>Language.Requested_by+Username</c> <strong>MAY BE SUBJECT TO CHANGE</strong>
        /// </remarks>

        public string RequestedBy { get; set; } = "Requested by ";
        /// <summary>
        /// Something went wrong, it's probably on my end.
        /// </summary>

        public string DblaReturnedNull { get; set; } = "Something went wrong, it's probably on my end.";

        /// <summary>
        /// must be en or de for useless facts
        /// </summary>
        public string LangCodeForUselessFacts { get; set; } = "en";

        //Music related
        /// <summary>
        ///I'm already in a voice channel!
        /// </summary>
        public string AlreadyConnected { get; set; } = "I'm already in a voice channel!";

        /// <summary>
        ///You must be in a voice channel!
        /// </summary>
        public string UserNotConnected { get; set; } = "You must be in a voice channel!";

        /// <summary>
        /// Please use a value between 0 and 100!
        /// </summary>
        public string VolumeNotCorrect { get; set; } = "Please use a value between 1 and 100%!";

        /// <summary>
        /// <b>Joined </b>Testing<b>!</b>
        /// <para/>
        /// <b>Joined␣</b>{0}<b>!</b>
        /// </summary>
        /// <remarks>
        /// Needs to be used like <c>String.Format(Language.Joined,Channel));</c>
        /// </remarks>
        public string Joined { get; set; } = "Joined {0}!";

        /// <summary>
        /// I'm not connected to a voice channel.
        /// </summary>
        public string NotConnected { get; set; } = "I'm not connected to a voice channel.";

        /// <summary>
        /// Woaaah there, I'm not playing any tracks.
        /// </summary>
        public string NotPlaying { get; set; } = "Woah there, I'm not playing any tracks.";

        /// <summary>
        /// Woah there, there is nothing queued next.
        /// </summary>
        public string NothingInQueue { get; set; } = "Woah there, there is nothing queued next.";

        /// <summary>
        /// Never gonna give you up<b> by </b>Rick Astley
        /// <para/>
        /// <b>␣by␣</b>
        /// </summary>
        /// <remarks>
        /// Needs to be used like <c>Title+Language.Song_by_author+Author</c>
        /// </remarks>
        public string SongByAuthor { get; set; } = " by ";

        public string RemovedFront { get; set; } = "Removed: "; //"Removed: "Never gonna give you up by Rick Astley

        /// <summary>
        /// Now loopin song 🔂
        /// </summary>
        public string LoopingSong { get; set; } = "Now loopin song 🔂";

        /// <summary>
        /// Send **an** image my guy
        /// </summary>
        public string WrongImageCount { get; set; } = "Send **an** image my guy";

        /// <summary>
        /// Now not loopin.
        /// </summary>
        public string NotLooping { get; set; } = "Now not loopin.";

        /// <summary>
        /// I wasn't able to find anything for `Never gonna give you up`.
        /// </summary>
        /// <remarks>
        ///  I wasn't able to find anything for `{0}`.
        /// </remarks>
        public string NoResults { get; set; } = "I wasn't able to find anything for `{0}`"; //I wasn't able to find anything for `"Never gonna give you up`.

        /// <summary>
        /// I've left {0}!
        /// </summary>
        public string Left { get; set; } = "I've left {0}!";

        /// <summary>
        /// Information about␣
        /// </summary>
        public string InformationAbout { get; set; } = "Information about ";

        /// <summary>
        /// Has joined the SilverCraft Discord
        /// </summary>
        public string JoinedSilverCraft { get; set; } = "Has joined the SilverCraft Discord";

        /// <summary>
        /// Prefix used
        /// </summary>
        public string PrefixUsedTopgg { get; set; } = "Prefix used";

        /// <summary>
        /// User:␣
        /// </summary>
        public string User { get; set; } = "User: ";

        /// <summary>
        /// ID
        /// </summary>
        public string Userid { get; set; } = "ID";

        /// <summary>
        /// Is a SilverCraft bot owner
        /// </summary>
        public string IsAnOwner { get; set; } = "Is a SilverCraft bot owner";

        /// <summary>
        /// Is a bot
        /// </summary>
        public string IsABot { get; set; } = "Is a bot";

        /// <summary>
        ///SilverBot sponsored by SilverHosting
        /// </summary>
        public string SilverhostingJokeTitle { get; set; } = "SilverBot sponsored by SilverHosting";

        /// <summary>
        ///Use offer code [SLVR](https://www.youtube.com/watch?v=dQw4w9WgXcQ)
        /// </summary>
        public string SilverhostingJokeDescription { get; set; } = "Use offer code [SLVR](https://www.youtube.com/watch?v=dQw4w9WgXcQ)";

        public string PurgeNumberNegative { get; set; } = "The amount of messages to remove must be positive.";
        public string PurgeNothingToDelete { get; set; } = "Nothing to delete.";

        public string PurgeRemovedFront { get; set; } = "Done. Removed "; //"Done. Removed "69 messages
        public string PurgeRemovedSingle { get; set; } = " message"; //Done. Removed 1" message"
        public string PurgeRemovedPlural { get; set; } = " messages"; //Done. Removed 69" messages"

        /// <summary>
        /// **No emote found**
        /// </summary>
        public string NoEmotesFound { get; set; } = "**No emote found**";

        /// <summary>
        /// Searched for: `{0}`
        /// </summary>
        public string SearchedFor { get; set; } = "Searched for: `{0}`";

        /// <summary>
        /// **Multiple emotes found**
        /// </summary>
        public string MultipleEmotesFound { get; set; } = "**Multiple emotes found**";

        /// <summary>
        /// Already opted into SilverBot emotes
        /// </summary>
        public string AlreadyOptedIn { get; set; } = "Already opted into SilverBot emotes";

        /// <summary>
        /// Server :{0}
        /// </summary>
        public string Server { get; set; } = "Server: {0}";

        /// <summary>
        /// Opted into SilverBot emotes
        /// </summary>
        public string OptedIn { get; set; } = "Opted into SilverBot emotes";

        /// <summary>
        /// **All available emotes**
        /// </summary>
        public string AllAvailibleEmotes { get; set; } = "**All available emotes**";

        /// <summary>
        /// You are banned from using the silversocial features
        /// </summary>
        public string UserIsBannedFromSilversocial { get; set; } = "You are banned from using the silversocial features";

        public string TimeFormat { get; set; } = "G"; //https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings?redirectedfrom=MSDN

        public string UselessFact { get; set; } = "Useless fact";

        /// <summary>
        /// You must have a higher role than the person you are trying to␣
        /// </summary>
        public string UserHasLowerRole { get; set; } = "You must have a higher role than the person you are trying to ";

        public string Ban { get; set; } = "ban";
        public string Kick { get; set; } = "kick";
        public string BotHasLowerRole { get; set; } = "I must have a higher role than the person you are trying to ";
        public string RandomGif { get; set; } = "Random GIF:";

        /// <summary>
        /// Powered by GIPHY
        /// </summary>
        public string PoweredByGiphy { get; set; } = "Powered by GIPHY";

        /// <summary>
        /// Meme:␣
        /// </summary>
        public string Meme { get; set; } = "Meme: ";

        /// <summary>
        /// You didnt attach a image
        /// </summary>
        /// <remarks>
        /// Ment to be used when there isnt a more better term
        /// </remarks>
        public string NoImageGeneric { get; set; } = "You didnt attach a image";

        /// <summary>
        /// Bruv discord no likey you need something less than 256kb you sent {0}
        /// </summary>
        public string EmoteWasLargerThan256K { get; set; } = "Bruv discord no likey you need something less than 256kb you sent {0}";

        /// <summary>
        /// You attached more than one image
        /// </summary>
        /// <remarks>
        /// Ment to be used when there isnt a more better term
        /// </remarks>
        public string MoreThanOneImageGeneric { get; set; } = "You attached more than one image";

        /// <summary>
        /// The output file is larger than 8mb, its {0}
        /// </summary>
        /// <remarks>
        /// Ment to be used when there isnt a more better term
        /// </remarks>
        public string OutputFileLargerThan8M { get; set; } = "The output file is larger than 8mb, its {0}";

        /// <summary>
        /// Page {0}/{1} Use `next` in the next 5 min to see the next page
        /// </summary>
        public string PageGif { get; set; } = "Page {0}/{1} Use `next` in the next 5 min to see the next page";

        /// <summary>
        /// Page {0}/{1}
        /// </summary>
        public string PageNuget { get; set; } = "Page {0}/{1}";

        /// <summary>
        /// You may not send `next` as the 5 minutes expired
        /// </summary>
        public string PeriodExpired { get; set; } = "You may not send `next` as the 5 minutes expired";

        /// <summary>
        /// Hey that isn't a bot, i think.
        /// </summary>
        public string UserIsntBot { get; set; } = "Hey that isn't a bot, i think.";

        /// <summary>
        /// Now playing: {0}
        /// </summary>
        public string NowPlaying { get; set; } = "Now playing: {0}";

        /// <summary>
        /// Enqueued: {0}
        /// </summary>
        public string Enqueued { get; set; } = "Enqueued: {0}";

        /// <summary>
        /// Skipped: {0}, Now playing {1}
        /// </summary>
        public string SkippedNP { get; set; } = "Skipped: {0}, Now playing {1}";

        /// <summary>
        /// You can use `sd!forceskip` to instantly skip the song
        /// </summary>
        public string CanForceSkip { get; set; } = "You can use `sd!forceskip` to instantly skip the song";

        /// <summary>
        /// It's not paused right now.
        /// </summary>
        public string NotPaused { get; set; } = "It's not paused right now.";

        /// <summary>
        /// Your vote was counted
        /// </summary>
        public string Voted { get; set; } = "Your vote was counted";

        /// <summary>
        /// Your vote was counted already
        /// </summary>
        public string AlreadyVoted { get; set; } = "Your vote was counted already";

        /// <summary>
        /// Estimated time till it plays:
        /// </summary>
        public string TimeTillTrackPlays { get; set; } = "Estimated time till it plays:";

        /// <summary>
        /// Uh oh something went wrong. Please try again a little bit later.
        /// </summary>
        public string SearchFail { get; set; } = "Uh oh something went wrong. Please try again a little bit later.";

        /// <summary>
        /// Uh oh something went wrong.
        /// </summary>
        public string SearchFailTitle { get; set; } = "Uh oh something went wrong.";

        /// <summary>
        /// Please try again a little bit later.
        /// </summary>
        public string SearchFailDescription { get; set; } = "Please try again a little bit later.";

        public string Success { get; set; } = "GREAT SUCCESS! HIGH FIVE EPIC GAMERS";
        public string UrbanExample { get; set; } = "Example";
        public string SongLength { get; set; } = "Length";
        public string SongTimePosition { get; set; } = "Position";
        public string SongTimeLeft { get; set; } = "Time left:";

        /// <summary>
        /// Never (song is looping)
        /// </summary>
        public string SongTimeLeftSongLoopingCurrent { get; set; } = "Never (current song is looping)";

        /// <summary>
        /// Never (current song is looping)
        /// </summary>
        public string SongTimeLeftSongLooping { get; set; } = "Never (song is looping)";

        public string SongNotExist { get; set; } = "That song does not exist my dude";
        public string VersionInfoTitle { get; set; } = "SilverBot Version info";
        public string PurgedBySilverBotReason { get; set; } = "Purged by SilverBot for {0}";
        public string NotValidLanguage { get; set; } = "That isn't a valid language, valid languages are:{0}";
        public string CultureInfo { get; set; } = "en-GB";
        public VersioninfoCommand VersionInfoCommand { get; set; } = new();
        public NugetCommand NuGetCommand { get; set; } = new();
        public MathCommands Mathcommands { get; set; } = new();
        public string BotBannedUser { get; set; } = "The bot has attempted to ban the user";
        public string BotKickedUser { get; set; } = "The bot has attempted to kick the user";
        public string AddedXAmountOfSongs { get; set; } = "Added {0} songs to the queue";

        public CultureInfo GetCultureInfo()
        {
            return new CultureInfo(CultureInfo);
        }

        public ImageThings Imagethings { get; set; } = new();

        private static readonly Dictionary<string, Language> CachedLanguages = new();
        private static readonly bool Logging = true;

        public static string[] LoadedLanguages()
        {
            if (CachedLanguages.Count == 0)
            {
                var t = GetAsync("en");
                t.Wait();
            }
            return CachedLanguages.Keys.ToArray();
        }

        private static readonly char DirSlash = Environment.OSVersion.Platform == PlatformID.Win32NT ? '\\' : '/';

        public static async System.Threading.Tasks.Task<Language> GetAsync(string a)
        {
            a = a.Trim();
            if (CachedLanguages.Count != 0)
            {
                if (CachedLanguages.ContainsKey(a))
                {
                    if (Logging)
                    {
                        Program.SendLog($"[LANGUAGES] huge success retriving {a} from cache", true);
                    }
                    return CachedLanguages[a];
                }
                else
                {
                    if (Logging)
                    {
                        Program.SendLog($"[LANGUAGES] huge fail loading {a} from cache", true);
                    }
                    return new Language();
                }
            }
            else
            {
                if (Directory.Exists(Environment.CurrentDirectory + DirSlash + "languages" + DirSlash))
                {
                    foreach (var u in Directory.GetFiles(Environment.CurrentDirectory + DirSlash + "languages" + DirSlash))
                    {
                        await using Stream stream = File.OpenRead(u);
                        var reader = new StreamReader(stream);
                        var content = await reader.ReadToEndAsync();
                        reader.Close();
                        reader.Dispose();
                        var asdf = JsonSerializer.Deserialize<Language>(content);
                        var name = Path.GetFileNameWithoutExtension(u);
                        CachedLanguages.Add(name, asdf);
                    }
                }
                else
                {
                    Directory.CreateDirectory(Environment.CurrentDirectory + DirSlash + "languages" + DirSlash);
                    using var streamWriter = new StreamWriter(Environment.CurrentDirectory + $"{DirSlash}languages{DirSlash}en.json");
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true
                    };
                    await streamWriter.WriteAsync(JsonSerializer.Serialize(new Language(), options));
                }
                if (Logging)
                {
                    Program.SendLog($"[LANGUAGES] done reading languages, {CachedLanguages.Count} have been loaded into cache", true);
                }
                return await GetAsync(a);
            }
        }

        public static async System.Threading.Tasks.Task<Language> GetLanguageFromCtxAsync(CommandContext ctx)
        {
            var db = Program.GetDatabase();
            return await GetAsync(ctx.Channel.IsPrivate ? await db.GetLangCodeUser(ctx.User.Id) : await db.GetLangCodeGuild(ctx.Guild.Id));
        }
    }
}