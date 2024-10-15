// Decompiled with JetBrains decompiler
// Type: PlayerPrefsUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System;
using System.Collections.Generic;
using System.Diagnostics;

#nullable disable
[Token(Token = "0x200013D")]
public class PlayerPrefsUtility
{
  [Token(Token = "0x400058B")]
  private const string GN_SOUND = "サウンド設定";
  [Token(Token = "0x400058C")]
  private const string GN_DEBUG = "デバッグ用";
  [Token(Token = "0x400058D")]
  private const string GN_IOS_TERMS = "iOS規約対応";
  [Token(Token = "0x400058E")]
  private const string GN_PARTY = "パーティ";
  [Token(Token = "0x400058F")]
  private const string GN_PARTY_EDIT = "パーティ編成情報";
  [Token(Token = "0x4000590")]
  private const string GN_SORT_FILTER = "ソート/フィルター";
  [Token(Token = "0x4000591")]
  [FieldOffset(Offset = "0x0")]
  public static readonly string CONFIG_SOUNDVOLUME;
  [Token(Token = "0x4000592")]
  [FieldOffset(Offset = "0x4")]
  public static readonly string CONFIG_MUSICVOLUME;
  [Token(Token = "0x4000593")]
  [FieldOffset(Offset = "0x8")]
  public static readonly string CONFIG_VOICEVOLUME;
  [Token(Token = "0x4000594")]
  [FieldOffset(Offset = "0xC")]
  public static readonly string CONFIG_INPUTMETHOD;
  [Token(Token = "0x4000595")]
  [FieldOffset(Offset = "0x10")]
  public static readonly string CONFIG_OKYAKUSAMACODE;
  [Token(Token = "0x4000596")]
  [FieldOffset(Offset = "0x14")]
  public static readonly string PARTY_TEAM_PREFIX;
  [Token(Token = "0x4000597")]
  [FieldOffset(Offset = "0x18")]
  public static readonly string PARTY_TEAM_SUFFIX;
  [Token(Token = "0x4000598")]
  [FieldOffset(Offset = "0x1C")]
  public static readonly string VERSUS_ID_KEY;
  [Token(Token = "0x4000599")]
  [FieldOffset(Offset = "0x20")]
  public static readonly string RANKMATCH_ID_KEY;
  [Token(Token = "0x400059A")]
  [FieldOffset(Offset = "0x24")]
  public static readonly string MULTITW_ID_KEY;
  [Token(Token = "0x400059B")]
  [FieldOffset(Offset = "0x28")]
  public static readonly string LEAGUEMATCH_ID_KEY;
  [Token(Token = "0x400059C")]
  [FieldOffset(Offset = "0x2C")]
  public static readonly string FRIEND_REQUEST_CACHE;
  [Token(Token = "0x400059D")]
  [FieldOffset(Offset = "0x30")]
  public static readonly string HOME_LASTACCESS_PLAYER_LV;
  [Token(Token = "0x400059E")]
  [FieldOffset(Offset = "0x34")]
  public static readonly string HOME_LASTACCESS_VIP_LV;
  [Token(Token = "0x400059F")]
  [FieldOffset(Offset = "0x38")]
  public static readonly string PREFS_KEY_FRIEND_SORT;
  [Token(Token = "0x40005A0")]
  [FieldOffset(Offset = "0x3C")]
  public static readonly string SAVE_UPDATE_TROPHY_LIST_KEY;
  [Token(Token = "0x40005A1")]
  [FieldOffset(Offset = "0x40")]
  public static readonly string GAMEMANAGER_UPSCALE;
  [Token(Token = "0x40005A2")]
  [FieldOffset(Offset = "0x44")]
  public static readonly string TEAM_ID_KEY;
  [Token(Token = "0x40005A3")]
  [FieldOffset(Offset = "0x48")]
  public static readonly string MULTI_PLAY_TEAM_ID_KEY;
  [Token(Token = "0x40005A4")]
  [FieldOffset(Offset = "0x4C")]
  public static readonly string ARENA_TEAM_ID_KEY;
  [Token(Token = "0x40005A5")]
  [FieldOffset(Offset = "0x50")]
  public static readonly string RANKMATCH_TEAM_ID_KEY;
  [Token(Token = "0x40005A6")]
  [FieldOffset(Offset = "0x54")]
  public static readonly string RAID_TEAM_ID_KEY;
  [Token(Token = "0x40005A7")]
  [FieldOffset(Offset = "0x58")]
  public static readonly string ROOM_COMMENT_KEY;
  [Token(Token = "0x40005A8")]
  [FieldOffset(Offset = "0x5C")]
  public static readonly string MULTI_HI_SPEED;
  [Token(Token = "0x40005A9")]
  [FieldOffset(Offset = "0x60")]
  public static readonly string MULTI_BATTLE_SPEED;
  [Token(Token = "0x40005AA")]
  [FieldOffset(Offset = "0x64")]
  public static readonly string MULTI_AUTO_ALLOWED;
  [Token(Token = "0x40005AB")]
  [FieldOffset(Offset = "0x68")]
  public static readonly string USE_ASSETBUNDLES;
  [Token(Token = "0x40005AC")]
  [FieldOffset(Offset = "0x6C")]
  public static readonly string USE_SERIALIZED_PARAMS;
  [Token(Token = "0x40005AD")]
  [FieldOffset(Offset = "0x70")]
  public static readonly string USE_ENCRYPTION;
  [Token(Token = "0x40005AE")]
  [FieldOffset(Offset = "0x74")]
  public static readonly string DEBUG_USE_DEV_SERVER;
  [Token(Token = "0x40005AF")]
  [FieldOffset(Offset = "0x78")]
  public static readonly string DEBUG_USE_AWS_SERVER;
  [Token(Token = "0x40005B0")]
  [FieldOffset(Offset = "0x7C")]
  public static readonly string DEBUG_NEWGAME;
  [Token(Token = "0x40005B1")]
  [FieldOffset(Offset = "0x80")]
  public static readonly string DEBUG_USE_LOCAL_DATA;
  [Token(Token = "0x40005B2")]
  [FieldOffset(Offset = "0x84")]
  public static readonly string DEBUG_USE_SERVER_DATA;
  [Token(Token = "0x40005B3")]
  [FieldOffset(Offset = "0x88")]
  public static readonly string DEBUG_AUTO_MARK;
  [Token(Token = "0x40005B4")]
  [FieldOffset(Offset = "0x8C")]
  public static readonly string DEBUG_AUTOPLAY;
  [Token(Token = "0x40005B5")]
  [FieldOffset(Offset = "0x90")]
  public static readonly string DEBUG_IS_PLAY_TUTORIAL;
  [Token(Token = "0x40005B6")]
  [FieldOffset(Offset = "0x94")]
  public static readonly string SCENESTARTUP_CLEARCACHE;
  [Token(Token = "0x40005B7")]
  [FieldOffset(Offset = "0x98")]
  public static readonly string PLAYERDATA_INVENTORY;
  [Token(Token = "0x40005B8")]
  [FieldOffset(Offset = "0x9C")]
  public static readonly string ALTER_PREV_CHECK_HASH;
  [Token(Token = "0x40005B9")]
  [FieldOffset(Offset = "0xA0")]
  public static readonly string UNITLIST_UNIT_SORT_MODE;
  [Token(Token = "0x40005BA")]
  [FieldOffset(Offset = "0xA4")]
  public static readonly string UNIT_SORT_FILTER_PREFIX;
  [Token(Token = "0x40005BB")]
  public const string FILTER_UNIT = "FilterUnit";
  [Token(Token = "0x40005BC")]
  [FieldOffset(Offset = "0xA8")]
  public static readonly string FILTER_CONCEPT_CARD;
  [Token(Token = "0x40005BD")]
  [FieldOffset(Offset = "0xAC")]
  public static readonly string FILTER_CONCEPT_CARD_EXTRA_RARITY;
  [Token(Token = "0x40005BE")]
  [FieldOffset(Offset = "0xB0")]
  public static readonly string FILTER_RUNE;
  [Token(Token = "0x40005BF")]
  [FieldOffset(Offset = "0xB4")]
  public static readonly string FILTER_RUNE_REPLACE;
  [Token(Token = "0x40005C0")]
  public const string FILTER_ARTIFACT = "FilterArtifact";
  [Token(Token = "0x40005C1")]
  [FieldOffset(Offset = "0xB8")]
  public static readonly string SORT_ARTIFACT;
  [Token(Token = "0x40005C2")]
  public const string SORT_RUNE = "SortRune";
  [Token(Token = "0x40005C3")]
  [FieldOffset(Offset = "0xBC")]
  public static readonly string EDITOR_SELECT_PLATFORM;
  [Token(Token = "0x40005C4")]
  [FieldOffset(Offset = "0xC0")]
  public static readonly string CONFIG_USE_PUSH_STAMINA;
  [Token(Token = "0x40005C5")]
  [FieldOffset(Offset = "0xC4")]
  public static readonly string CONFIG_USE_PUSH_NEWS;
  [Token(Token = "0x40005C6")]
  [FieldOffset(Offset = "0xC8")]
  public static readonly string CONFIG_USE_CHAT_STATE;
  [Token(Token = "0x40005C7")]
  [FieldOffset(Offset = "0xCC")]
  public static readonly string CONFIG_USE_STAMP_STATE;
  [Token(Token = "0x40005C8")]
  [FieldOffset(Offset = "0xD0")]
  public static readonly string CONFIG_USE_CHARGE_DISP;
  [Token(Token = "0x40005C9")]
  [FieldOffset(Offset = "0xD4")]
  public static readonly string CONFIG_USE_AUTO_PLAY;
  [Token(Token = "0x40005CA")]
  [FieldOffset(Offset = "0xD8")]
  public static readonly string CONFIG_USE_AUTOMODE_TREASURE;
  [Token(Token = "0x40005CB")]
  [FieldOffset(Offset = "0xDC")]
  public static readonly string CONFIG_USE_AUTOMODE_DISABLE_SKILL;
  [Token(Token = "0x40005CC")]
  [FieldOffset(Offset = "0xE0")]
  public static readonly string CONFIG_USE_DIRECTIONCUT;
  [Token(Token = "0x40005CD")]
  [FieldOffset(Offset = "0xE4")]
  public static readonly string CONFIG_USE_AUTO_PLAY_MULTI;
  [Token(Token = "0x40005CE")]
  [FieldOffset(Offset = "0xE8")]
  public static readonly string CONFIG_USE_AUTOMODE_TREASURE_MULTI;
  [Token(Token = "0x40005CF")]
  [FieldOffset(Offset = "0xEC")]
  public static readonly string CONFIG_USE_AUTOMODE_DISABLE_SKILL_MULTI;
  [Token(Token = "0x40005D0")]
  [FieldOffset(Offset = "0xF0")]
  public static readonly string CONFIG_USE_AUTO_PLAY_RM;
  [Token(Token = "0x40005D1")]
  [FieldOffset(Offset = "0xF4")]
  public static readonly string CONFIG_USE_AUTO_PLAY_VS;
  [Token(Token = "0x40005D2")]
  [FieldOffset(Offset = "0xF8")]
  public static readonly string CONFIG_USE_AUTO_PLAY_DRAFT;
  [Token(Token = "0x40005D3")]
  [FieldOffset(Offset = "0xFC")]
  public static readonly string CONFIG_USE_AUTO_PLAY_LEAGUEMATCH;
  [Token(Token = "0x40005D4")]
  [FieldOffset(Offset = "0x100")]
  public static readonly string LAST_MATCHING_NPC_ID_RM;
  [Token(Token = "0x40005D5")]
  [FieldOffset(Offset = "0x104")]
  public static readonly string CONFIG_USE_BATTLE_SPEED;
  [Token(Token = "0x40005D6")]
  [FieldOffset(Offset = "0x108")]
  public static readonly string RECOMMENDED_TEAM_SETTING_KEY;
  [Token(Token = "0x40005D7")]
  [FieldOffset(Offset = "0x10C")]
  public static readonly string UNIT_LEVELUP_EXPITEM_CHECKS;
  [Token(Token = "0x40005D8")]
  [FieldOffset(Offset = "0x110")]
  public static readonly string ARTIFACT_BULK_LEVELUP;
  [Token(Token = "0x40005D9")]
  [FieldOffset(Offset = "0x114")]
  public static readonly string ARTIFACT_RARITY_UP_MAX_TOGGLE;
  [Token(Token = "0x40005DA")]
  [FieldOffset(Offset = "0x118")]
  public static readonly string CONCEPT_CARD_LEVELUP_EXPITEM_CHECKS;
  [Token(Token = "0x40005DB")]
  [FieldOffset(Offset = "0x11C")]
  public static readonly string CONCEPT_CARD_LEVELUP_PAGE_CHECKS;
  [Token(Token = "0x40005DC")]
  [FieldOffset(Offset = "0x120")]
  public static readonly string UNIT_AWAKE_PIECE_CHECKS;
  [Token(Token = "0x40005DD")]
  [FieldOffset(Offset = "0x124")]
  public static readonly string CHAT_TEMPLATE_MESSAGE;
  [Token(Token = "0x40005DE")]
  [FieldOffset(Offset = "0x128")]
  public static readonly string CHAT_OFFICIAL_MESSAGE_LAST_READ_DATE;
  [Token(Token = "0x40005DF")]
  [FieldOffset(Offset = "0x12C")]
  public static readonly string CHALLENGEMISSION_HAS_SHOW_MESSAGE;
  [Token(Token = "0x40005E0")]
  [FieldOffset(Offset = "0x130")]
  public static readonly string AWAKE_VERSION;
  [Token(Token = "0x40005E1")]
  [FieldOffset(Offset = "0x134")]
  public static readonly string ARTIFACT_EXCLUDE_EQUIPED;
  [Token(Token = "0x40005E2")]
  [FieldOffset(Offset = "0x138")]
  public static readonly string GALLERY_SETTING;
  [Token(Token = "0x40005E3")]
  [FieldOffset(Offset = "0x13C")]
  public static readonly string GALLERY_CONCEPTCARD_SETTING;
  [Token(Token = "0x40005E4")]
  [FieldOffset(Offset = "0x140")]
  public static readonly string GALLERY_ARTIFACT_SETTING;
  [Token(Token = "0x40005E5")]
  [FieldOffset(Offset = "0x144")]
  public static readonly string CONCEPTCARD_EXCLUDE_EQUIPED;
  [Token(Token = "0x40005E6")]
  [FieldOffset(Offset = "0x148")]
  public static readonly string ORDEAL_RELEASE_ANIMATION_PLAYED;
  [Token(Token = "0x40005E7")]
  [FieldOffset(Offset = "0x14C")]
  public static readonly string RANKMATCH_SEASON_REWARD_RECEIVE_DATE;
  [Token(Token = "0x40005E8")]
  [FieldOffset(Offset = "0x150")]
  public static readonly string RAID_RANKING_RECEIVE_DATE;
  [Token(Token = "0x40005E9")]
  [FieldOffset(Offset = "0x154")]
  public static readonly string GUILDRAID_RANKING_RECEIVE_DATE;
  [Token(Token = "0x40005EA")]
  [FieldOffset(Offset = "0x158")]
  public static readonly string WORLDRAID_REWARD_RECEIVE_DATE;
  [Token(Token = "0x40005EB")]
  [FieldOffset(Offset = "0x15C")]
  public static readonly string UNLOCK_LEVEL_ANIMATION_PLAYED;
  [Token(Token = "0x40005EC")]
  [FieldOffset(Offset = "0x160")]
  public static readonly string UNLOCK_LEVEL_NOTIFIED;
  [Token(Token = "0x40005ED")]
  [FieldOffset(Offset = "0x164")]
  public static readonly string WARNED_SHOP_ITEM_TIMEOUT;
  [Token(Token = "0x40005EE")]
  [FieldOffset(Offset = "0x168")]
  public static readonly string WARNED_EVENTSHOP_ITEM_TIMEOUT;
  [Token(Token = "0x40005EF")]
  [FieldOffset(Offset = "0x16C")]
  public static readonly string WARNED_LIMITEDSHOP_ITEM_TIMEOUT;
  [Token(Token = "0x40005F0")]
  [FieldOffset(Offset = "0x170")]
  public static readonly string WARNED_PORTSHOP_ITEM_TIMEOUT;
  [Token(Token = "0x40005F1")]
  [FieldOffset(Offset = "0x174")]
  public static readonly string JUKEBOX_UNLOCK_BADGE_INFO;
  [Token(Token = "0x40005F2")]
  [FieldOffset(Offset = "0x178")]
  public static readonly string RELEASE_STORY_PART_KEY;
  [Token(Token = "0x40005F3")]
  [FieldOffset(Offset = "0x17C")]
  public static readonly string CONFIRM_TOWER_MISSION_QUEST_ID;
  [Token(Token = "0x40005F4")]
  [FieldOffset(Offset = "0x180")]
  public static readonly string LAST_SELECTED_STORY_QUEST_ID;
  [Token(Token = "0x40005F5")]
  [FieldOffset(Offset = "0x184")]
  public static readonly string BEGINNER_TOP_HAS_VISITED;
  [Token(Token = "0x40005F6")]
  [FieldOffset(Offset = "0x188")]
  public static readonly string LAST_BEGINNER_NOTIFIED_DATE;
  [Token(Token = "0x40005F7")]
  [FieldOffset(Offset = "0x18C")]
  public static readonly string PREFS_KEY_GUILD_MEMBER_SORT;
  [Token(Token = "0x40005F8")]
  [FieldOffset(Offset = "0x190")]
  public static readonly string PREFS_KEY_USE_DLC;
  [Token(Token = "0x40005F9")]
  [FieldOffset(Offset = "0x194")]
  public static readonly string PREFS_KEY_TUTORIAL_CLEARED;
  [Token(Token = "0x40005FA")]
  [FieldOffset(Offset = "0x198")]
  public static readonly string PREFS_KEY_GENESIS_DIFF_OPEN_QUEST_CACHE;
  [Token(Token = "0x40005FB")]
  [FieldOffset(Offset = "0x19C")]
  public static readonly string PREFS_KEY_GENESIS_BOSS_OPEN_QUEST_CACHE;
  [Token(Token = "0x40005FC")]
  [FieldOffset(Offset = "0x1A0")]
  public static readonly string PREFS_KEY_GENESIS_SKIP_OPEN_QUEST_CACHE;
  [Token(Token = "0x40005FD")]
  [FieldOffset(Offset = "0x1A4")]
  public static readonly string PREFS_KEY_ADVANCE_DIFF_OPEN_QUEST_CACHE;
  [Token(Token = "0x40005FE")]
  [FieldOffset(Offset = "0x1A8")]
  public static readonly string PREFS_KEY_ADVANCE_BOSS_OPEN_QUEST_CACHE;
  [Token(Token = "0x40005FF")]
  [FieldOffset(Offset = "0x1AC")]
  public static readonly string PREFS_KEY_ADVANCE_SKIP_OPEN_QUEST_CACHE;
  [Token(Token = "0x4000600")]
  [FieldOffset(Offset = "0x1B0")]
  public static readonly string PREFS_GVG_PERIOD;
  [Token(Token = "0x4000601")]
  [FieldOffset(Offset = "0x1B4")]
  public static readonly string PREFS_GVG_PERIOD_LEAGUE;
  [Token(Token = "0x4000602")]
  [FieldOffset(Offset = "0x1B8")]
  public static readonly string PREFS_KEY_EXPIRE_ITEM;
  [Token(Token = "0x4000603")]
  [FieldOffset(Offset = "0x1BC")]
  public static readonly string IS_ENABLE_SHOW_SIZE_BEFORE_DOWNLOADING;
  [Token(Token = "0x4000604")]
  [FieldOffset(Offset = "0x1C0")]
  public static readonly string PREFS_KEY_GET_UNIT_QUESTS_POPUP_CACHE;
  [Token(Token = "0x4000605")]
  [FieldOffset(Offset = "0x1C4")]
  public static readonly string PREFS_KEY_LAST_SELECT_HOME_UNIT;
  [Token(Token = "0x4000606")]
  [FieldOffset(Offset = "0x1C8")]
  public static readonly string RUNE_EXCLUDE_EQUIPED;
  [Token(Token = "0x4000607")]
  [FieldOffset(Offset = "0x1CC")]
  public static readonly string PREFS_KEY_WORLD_RAID_NOTICE;
  [Token(Token = "0x4000608")]
  [FieldOffset(Offset = "0x1D0")]
  public static readonly string PREFS_KEY_WORLD_RAID_LOG_ID;
  [Token(Token = "0x4000609")]
  [FieldOffset(Offset = "0x1D4")]
  public static readonly string PREFS_KEY_ADVENTURE_NEW_FLAG;
  [Token(Token = "0x400060A")]
  [FieldOffset(Offset = "0x1D8")]
  public static readonly string PREFS_KEY_ADVENTURE_NOTIFICATION_LIST;
  [Token(Token = "0x400060B")]
  [FieldOffset(Offset = "0x1DC")]
  public static readonly string PREFS_KEY_BOND_GROUP_BADGE;
  [Token(Token = "0x400060C")]
  [FieldOffset(Offset = "0x1E0")]
  public static readonly string PREFS_KEY_BOND_FILTER_UNIT;
  [Token(Token = "0x400060D")]
  [FieldOffset(Offset = "0x1E4")]
  public static readonly string PREFS_KEY_BOND_FILTER_CAN_LVUP;
  [Token(Token = "0x400060E")]
  [FieldOffset(Offset = "0x1E8")]
  public static readonly string PREFS_KEY_BOND_OPEN_INFORM;
  [Token(Token = "0x400060F")]
  [FieldOffset(Offset = "0x1EC")]
  public static readonly string PREFS_KEY_BOND_CHECK_ITEM;
  [Token(Token = "0x4000610")]
  public const string PREFS_KEY_BOOKMARK_BULK_NUM = "BookmarkBulkNum";
  [Token(Token = "0x4000611")]
  public const string PREFS_KEY_BOOKMARK_CHECK_FILTER = "BookmarkCheckFilter";
  [Token(Token = "0x4000612")]
  public const string PREFS_KEY_BOOKMARK_FILTER_UNIT = "BookmarkFilterUnit";
  [Token(Token = "0x4000613")]
  public const string PREFS_KEY_BOOKMARK_FILTER_ELEMENT = "BookmarkFilterElement";
  [Token(Token = "0x4000614")]
  [FieldOffset(Offset = "0x1F0")]
  public static readonly string PREFS_KEY_BOOKMARK_AP_CHECK;
  [Token(Token = "0x4000615")]
  [FieldOffset(Offset = "0x1F4")]
  public static readonly string PREFS_KEY_GUILD_TRAINING_INIT_BADGE;
  [Token(Token = "0x4000616")]
  [FieldOffset(Offset = "0x1F8")]
  public static readonly string PREFS_KEY_GUILD_TRAINING_MAX_CHECK;
  [Token(Token = "0x4000617")]
  [FieldOffset(Offset = "0x1FC")]
  public static readonly string PREFS_KEY_PUSH_GUILD_TRAINING_ENEGRY;
  [Token(Token = "0x4000618")]
  [FieldOffset(Offset = "0x200")]
  public static readonly string PREFS_KEY_NAVI_VOICE_OPTION;
  [Token(Token = "0x4000619")]
  [FieldOffset(Offset = "0x204")]
  public static readonly string CONFIG_USE_FIRST_VIEW_RM;
  [Token(Token = "0x400061A")]
  [FieldOffset(Offset = "0x208")]
  public static readonly string RANKMATCH_SELECED_ONLY;
  [Token(Token = "0x400061B")]
  [FieldOffset(Offset = "0x20C")]
  public static readonly string PREFS_KEY_DRAGOON_DIFF_OPEN_QUEST_CACHE;
  [Token(Token = "0x400061C")]
  [FieldOffset(Offset = "0x210")]
  public static readonly string PREFS_KEY_DRAGOON_SKIP_OPEN_QUEST_CACHE;
  [Token(Token = "0x400061D")]
  [FieldOffset(Offset = "0x214")]
  public static readonly string GUILDRAID_WEBVIEW_CHECK_CACHE;
  [Token(Token = "0x400061E")]
  [FieldOffset(Offset = "0x218")]
  public static readonly string IS_ADVENTURE_SKIPMOVIE;
  [Token(Token = "0x400061F")]
  [FieldOffset(Offset = "0x21C")]
  public static readonly string IS_ADVENTURE_PUSHSTATE;
  [Token(Token = "0x4000620")]
  [FieldOffset(Offset = "0x220")]
  public static readonly string PREFS_KEY_ADVENTURE_USE_ITEM_MAX_CHECK;
  [Token(Token = "0x4000621")]
  [FieldOffset(Offset = "0x224")]
  public static readonly string CONFIRM_FIRST_MASTERYREWARD;
  [Token(Token = "0x4000622")]
  [FieldOffset(Offset = "0x228")]
  public static readonly string FILTER_CRYSTAL;
  [Token(Token = "0x4000623")]
  [FieldOffset(Offset = "0x22C")]
  public static readonly string FILTER_CRYSTAL_REPLACE;
  [Token(Token = "0x4000624")]
  [FieldOffset(Offset = "0x230")]
  public static readonly string SORT_CRYSTAL;
  [Token(Token = "0x4000625")]
  [FieldOffset(Offset = "0x234")]
  public static readonly string PREFS_KEY_CRYSTAL_REPLACE_CHECK_EQUIP;
  [Token(Token = "0x4000626")]
  [FieldOffset(Offset = "0x238")]
  public static readonly string CRYSTAL_EXCLUDE_EQUIPED;
  [Token(Token = "0x4000627")]
  public const string PREFS_KEY_RUNEREPLACE_CHECK_FILTER = "RuneReplaceCheckFilter";
  [Token(Token = "0x4000628")]
  [FieldOffset(Offset = "0x23C")]
  public static readonly string CONFIG_TROPHY_COLLECTIVE_RECEIPT_EXP;
  [Token(Token = "0x4000629")]
  [FieldOffset(Offset = "0x240")]
  public static readonly string IS_UNIT_JOB_RANKUP_COMMON_ITEM;
  [Token(Token = "0x400062A")]
  [FieldOffset(Offset = "0x244")]
  public static readonly string RUNE_PRIDE_PIECE_SELECT_LIST;
  [Token(Token = "0x400062B")]
  [FieldOffset(Offset = "0x248")]
  public static readonly string RUNE_PRIDE_MULTIPLE_STATE;
  [Token(Token = "0x400062C")]
  [FieldOffset(Offset = "0x24C")]
  public static readonly string SORT_ARTIFACTSTONE;
  [Token(Token = "0x400062D")]
  [FieldOffset(Offset = "0x250")]
  public static readonly string ARTIFACTSTONE_TODAY_CONFIRM;
  [Token(Token = "0x400062E")]
  public const string PREFS_KEY_PREFS_KEY_UNIT_EQUIP_RUNE_BULK_RELEASE_ALL_UNIT = "RuneBulkRelease";
  [Token(Token = "0x400062F")]
  public const string PREFS_KEY_PERMISSION_ANDROID_NOTIFICATIONS = "PREFS_KEY_PERMISSION_ANDROID_NOTIFICATIONS";
  [Token(Token = "0x4000630")]
  public const string PREFS_KEY_GPGS_PRIORITY_CONFIRMED = "PREFS_KEY_GPGS_PRIORITY_CONFIRMED";
  [Token(Token = "0x4000631")]
  [FieldOffset(Offset = "0x254")]
  public static readonly string PREFS_KEY_UNIT_STATUS_AWAKE_MAX_CHECK;
  [Token(Token = "0x4000632")]
  [FieldOffset(Offset = "0x258")]
  private static Dictionary<string, PlayerPrefsUtility.WinCacheData> mWinCache;

  [Token(Token = "0x60007CC")]
  [Address(RVA = "0xE4ED20", Offset = "0xE4DB20", VA = "0x10E4ED20")]
  public static string GetTeamKey(int index) => (string) null;

  [Token(Token = "0x1700011D")]
  private static string PLAYER_PREFS_DATA_PATH
  {
    [Token(Token = "0x60007CD"), Address(RVA = "0xE516F0", Offset = "0xE504F0", VA = "0x10E516F0")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x1700011E")]
  private static string PLAYER_PREFS_DATA_PATH_FORMAT
  {
    [Token(Token = "0x60007CE"), Address(RVA = "0xE51670", Offset = "0xE50470", VA = "0x10E51670")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x60007CF")]
  [Address(RVA = "0xE4F410", Offset = "0xE4E210", VA = "0x10E4F410")]
  public static bool SetInt(string key, int value, bool IsSave = false) => new bool();

  [Token(Token = "0x60007D0")]
  [Address(RVA = "0xE4EB50", Offset = "0xE4D950", VA = "0x10E4EB50")]
  public static int GetInt(string key, int default_value = 0) => new int();

  [Token(Token = "0x60007D1")]
  [Address(RVA = "0xE4F390", Offset = "0xE4E190", VA = "0x10E4F390")]
  public static bool SetFloat(string key, float value, bool IsSave = false) => new bool();

  [Token(Token = "0x60007D2")]
  [Address(RVA = "0xE4EAF0", Offset = "0xE4D8F0", VA = "0x10E4EAF0")]
  public static float GetFloat(string key, float default_value = 0.0f) => new float();

  [Token(Token = "0x60007D3")]
  [Address(RVA = "0xE4F4F0", Offset = "0xE4E2F0", VA = "0x10E4F4F0")]
  public static bool SetString(string key, string value, bool IsSave = false) => new bool();

  [Token(Token = "0x60007D4")]
  [Address(RVA = "0xE4ECC0", Offset = "0xE4DAC0", VA = "0x10E4ECC0")]
  public static string GetString(string key, string default_value = "") => (string) null;

  [Token(Token = "0x60007D5")]
  [Address(RVA = "0xE4F480", Offset = "0xE4E280", VA = "0x10E4F480")]
  public static bool SetLong(string key, long value, bool IsSave = false) => new bool();

  [Token(Token = "0x60007D6")]
  [Address(RVA = "0xE4EC60", Offset = "0xE4DA60", VA = "0x10E4EC60")]
  public static long GetLong(string key, long default_value = 0) => new long();

  [Token(Token = "0x60007D7")]
  [Address(RVA = "0xE4EE20", Offset = "0xE4DC20", VA = "0x10E4EE20")]
  public static bool HasKey(string key) => new bool();

  [Token(Token = "0x60007D8")]
  [Address(RVA = "0xE4EAA0", Offset = "0xE4D8A0", VA = "0x10E4EAA0")]
  public static void DeleteKey(string key)
  {
  }

  [Token(Token = "0x60007D9")]
  [Address(RVA = "0xE4E780", Offset = "0xE4D580", VA = "0x10E4E780")]
  public static void DeleteAll()
  {
  }

  [Token(Token = "0x60007DA")]
  [Address(RVA = "0xB55060", Offset = "0xB53E60", VA = "0x10B55060")]
  public static void Save()
  {
  }

  [Token(Token = "0x60007DB")]
  [Address(RVA = "0xE4F290", Offset = "0xE4E090", VA = "0x10E4F290")]
  public static void ResetMultiTowerPlacement()
  {
  }

  [Token(Token = "0x60007DC")]
  private static T CastValue<T>(string _str, T _default_value) => (T) null;

  [Token(Token = "0x60007DD")]
  [Address(RVA = "0xE4EFB0", Offset = "0xE4DDB0", VA = "0x10E4EFB0")]
  private static bool RegisterWinCacheAndCheckNeedCreateFile(string _key, string _default_value)
  {
    return new bool();
  }

  [Token(Token = "0x60007DE")]
  private static void SetForWindows<T>(string _key, T _value)
  {
  }

  [Token(Token = "0x60007DF")]
  private static T GetForWindow<T>(string _key, T _default_value) => (T) null;

  [Token(Token = "0x60007E0")]
  [Address(RVA = "0xE4ED40", Offset = "0xE4DB40", VA = "0x10E4ED40")]
  private static bool HasKeyForWindow(string _key) => new bool();

  [Token(Token = "0x60007E1")]
  [Address(RVA = "0xE4EF50", Offset = "0xE4DD50", VA = "0x10E4EF50")]
  private static bool IsExistFileForWindow(string _key) => new bool();

  [Token(Token = "0x60007E2")]
  [Address(RVA = "0xE4E8B0", Offset = "0xE4D6B0", VA = "0x10E4E8B0")]
  private static void DeleteKeyForWindows(string _key)
  {
  }

  [Token(Token = "0x60007E3")]
  [Address(RVA = "0xE4E680", Offset = "0xE4D480", VA = "0x10E4E680")]
  private static void DeleteAllForWindows()
  {
  }

  [Token(Token = "0x60007E4")]
  [Address(RVA = "0xE4F560", Offset = "0xE4E360", VA = "0x10E4F560")]
  public static void SetUnlockLevelAnimationPlayed(UnlockTargets value)
  {
  }

  [Token(Token = "0x60007E5")]
  [Address(RVA = "0xE4EBB0", Offset = "0xE4D9B0", VA = "0x10E4EBB0")]
  public static bool GetIsUnlockLevelAnimationPlayed(UnlockTargets value) => new bool();

  [Token(Token = "0x60007E6")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public PlayerPrefsUtility()
  {
  }

  [Token(Token = "0x60007E7")]
  [Address(RVA = "0xE4F690", Offset = "0xE4E490", VA = "0x10E4F690")]
  static PlayerPrefsUtility()
  {
  }

  [Token(Token = "0x200013E")]
  public enum ePlayerPrefsValueType
  {
    [Token(Token = "0x4000634")] Int,
    [Token(Token = "0x4000635")] Long,
    [Token(Token = "0x4000636")] Float,
    [Token(Token = "0x4000637")] String,
  }

  [Token(Token = "0x200013F")]
  public enum eAttributeType
  {
    [Token(Token = "0x4000639")] DirectKey,
    [Token(Token = "0x400063A")] IndexKey,
  }

  [Token(Token = "0x2000140")]
  [Conditional("UNITY_EDITOR")]
  [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, Inherited = true)]
  public class PlayerPrefsValueTypeAttribute : Attribute
  {
    [Token(Token = "0x400063B")]
    public const string DEFAULT_GROUP_NAME = "その他";
    [Token(Token = "0x400063C")]
    [FieldOffset(Offset = "0x8")]
    private string m_GroupName;
    [Token(Token = "0x400063D")]
    [FieldOffset(Offset = "0xC")]
    private string m_Description;
    [Token(Token = "0x400063E")]
    [FieldOffset(Offset = "0x10")]
    private PlayerPrefsUtility.ePlayerPrefsValueType m_ValueType;
    [Token(Token = "0x400063F")]
    [FieldOffset(Offset = "0x14")]
    protected PlayerPrefsUtility.eAttributeType m_AttributeType;

    [Token(Token = "0x1700011F")]
    public string GroupName
    {
      [Token(Token = "0x60007E8"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000120")]
    public string Description
    {
      [Token(Token = "0x60007E9"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000121")]
    public PlayerPrefsUtility.ePlayerPrefsValueType ValueType
    {
      [Token(Token = "0x60007EA"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new PlayerPrefsUtility.ePlayerPrefsValueType();
      }
    }

    [Token(Token = "0x17000122")]
    public PlayerPrefsUtility.eAttributeType AttributeType
    {
      [Token(Token = "0x60007EB"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new PlayerPrefsUtility.eAttributeType();
      }
    }

    [Token(Token = "0x60007EC")]
    [Address(RVA = "0xE51730", Offset = "0xE50530", VA = "0x10E51730")]
    public PlayerPrefsValueTypeAttribute(
      PlayerPrefsUtility.ePlayerPrefsValueType valueType,
      string groupName,
      string description)
    {
    }
  }

  [Token(Token = "0x2000141")]
  [Conditional("UNITY_EDITOR")]
  [AttributeUsage(AttributeTargets.Method, Inherited = false)]
  public class PlayerPrefsValueTypeUseIndexAttribute : 
    PlayerPrefsUtility.PlayerPrefsValueTypeAttribute
  {
    [Token(Token = "0x4000640")]
    [FieldOffset(Offset = "0x18")]
    private int m_Length;

    [Token(Token = "0x17000123")]
    public int Length
    {
      [Token(Token = "0x60007ED"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60007EE")]
    [Address(RVA = "0xE517A0", Offset = "0xE505A0", VA = "0x10E517A0")]
    public PlayerPrefsValueTypeUseIndexAttribute(
      PlayerPrefsUtility.ePlayerPrefsValueType valueType,
      string groupName,
      string description,
      int length)
    {
    }
  }

  [Token(Token = "0x2000142")]
  private class WinCacheData
  {
    [Token(Token = "0x4000641")]
    [FieldOffset(Offset = "0x8")]
    public string value;
    [Token(Token = "0x4000642")]
    [FieldOffset(Offset = "0xC")]
    public bool is_initalized;

    [Token(Token = "0x60007EF")]
    [Address(RVA = "0x305760", Offset = "0x304560", VA = "0x10305760")]
    public WinCacheData(string _value, bool _is_initalized = false)
    {
    }
  }
}
