// Decompiled with JetBrains decompiler
// Type: GameUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20000EC")]
public static class GameUtility
{
  [Token(Token = "0x4000410")]
  public const char TIME_SPLIT_SEPARATOR = ':';
  [Token(Token = "0x4000411")]
  [FieldOffset(Offset = "0x0")]
  private static Toggle.ToggleEvent nullToggleEvent;
  [Token(Token = "0x4000412")]
  [FieldOffset(Offset = "0x4")]
  private static StringBuilder mSB;
  [Token(Token = "0x4000413")]
  [FieldOffset(Offset = "0x8")]
  private static string LOGININFO_ALREADY_READ;
  [Token(Token = "0x4000414")]
  [FieldOffset(Offset = "0xC")]
  public static readonly string BEFORE_LOGIN_NEWS_INFO_TOKEN;
  [Token(Token = "0x4000415")]
  [FieldOffset(Offset = "0x10")]
  private static float m_sound_volume;
  [Token(Token = "0x4000416")]
  [FieldOffset(Offset = "0x14")]
  private static float m_music_volume;
  [Token(Token = "0x4000417")]
  [FieldOffset(Offset = "0x18")]
  private static float m_jukebox_bgm;
  [Token(Token = "0x4000418")]
  [FieldOffset(Offset = "0x1C")]
  private static float m_voice_volume;
  [Token(Token = "0x4000419")]
  public const string TUTORIAL_PLAYED = "TutorialPlayed";
  [Token(Token = "0x400041A")]
  [FieldOffset(Offset = "0x20")]
  public static GameUtility.BooleanConfig Config_UseAssetBundles;
  [Token(Token = "0x400041B")]
  [FieldOffset(Offset = "0x24")]
  public static GameUtility.BooleanConfigWithEnvBitFlagCheck Config_UseSerializedParams;
  [Token(Token = "0x400041C")]
  [FieldOffset(Offset = "0x28")]
  public static GameUtility.BooleanConfigWithEnvBitFlagCheck Config_UseEncryption;
  [Token(Token = "0x400041D")]
  [FieldOffset(Offset = "0x2C")]
  public static GameUtility.BooleanConfig Config_UseDevServer;
  [Token(Token = "0x400041E")]
  [FieldOffset(Offset = "0x30")]
  public static GameUtility.BooleanConfig Config_UseAwsServer;
  [Token(Token = "0x400041F")]
  [FieldOffset(Offset = "0x34")]
  public static GameUtility.BooleanConfig Config_NewGame;
  [Token(Token = "0x4000420")]
  [FieldOffset(Offset = "0x38")]
  public static GameUtility.BooleanConfig Config_UseLocalData;
  [Token(Token = "0x4000421")]
  [FieldOffset(Offset = "0x3C")]
  public static GameUtility.BooleanConfig Config_UseServerData;
  [Token(Token = "0x4000422")]
  [FieldOffset(Offset = "0x40")]
  public static GameUtility.BooleanConfig Config_AutoPlayMark;
  [Token(Token = "0x4000423")]
  [FieldOffset(Offset = "0x44")]
  public static GameUtility.BooleanConfig Config_AutoPlay;
  [Token(Token = "0x4000424")]
  [FieldOffset(Offset = "0x48")]
  public static GameUtility.BooleanConfig Config_UseAutoPlay;
  [Token(Token = "0x4000425")]
  [FieldOffset(Offset = "0x4C")]
  public static GameUtility.BooleanConfig Config_AutoMode_Treasure;
  [Token(Token = "0x4000426")]
  [FieldOffset(Offset = "0x50")]
  public static GameUtility.BooleanConfig Config_AutoMode_DisableSkill;
  [Token(Token = "0x4000427")]
  [FieldOffset(Offset = "0x54")]
  public static GameUtility.BooleanConfig Config_DirectionCut;
  [Token(Token = "0x4000428")]
  [FieldOffset(Offset = "0x58")]
  public static GameUtility.BooleanConfig Config_UseBattleSpeed;
  [Token(Token = "0x4000429")]
  [FieldOffset(Offset = "0x5C")]
  public static GameUtility.BooleanConfig Config_UseAutoPlayMulti;
  [Token(Token = "0x400042A")]
  [FieldOffset(Offset = "0x60")]
  public static GameUtility.BooleanConfig Config_AutoMode_TreasureMulti;
  [Token(Token = "0x400042B")]
  [FieldOffset(Offset = "0x64")]
  public static GameUtility.BooleanConfig Config_AutoMode_DisableSkillMulti;
  [Token(Token = "0x400042C")]
  [FieldOffset(Offset = "0x68")]
  public static GameUtility.BooleanConfig Config_UseAutoPlayRM;
  [Token(Token = "0x400042D")]
  [FieldOffset(Offset = "0x6C")]
  public static GameUtility.BooleanConfig Config_UseAutoPlayVS;
  [Token(Token = "0x400042E")]
  [FieldOffset(Offset = "0x70")]
  public static GameUtility.BooleanConfig Config_UseAutoPlayDraft;
  [Token(Token = "0x400042F")]
  [FieldOffset(Offset = "0x74")]
  public static GameUtility.BooleanConfig Config_UseAutoPlayLeagueMatch;
  [Token(Token = "0x4000430")]
  [FieldOffset(Offset = "0x78")]
  public static GameUtility.BooleanConfig Config_UsePushStamina;
  [Token(Token = "0x4000431")]
  [FieldOffset(Offset = "0x7C")]
  public static GameUtility.BooleanConfig Config_UsePushNews;
  [Token(Token = "0x4000432")]
  [FieldOffset(Offset = "0x80")]
  public static GameUtility.BooleanConfig Config_ChatState;
  [Token(Token = "0x4000433")]
  [FieldOffset(Offset = "0x84")]
  public static GameUtility.BooleanConfig Config_MultiState;
  [Token(Token = "0x4000434")]
  [FieldOffset(Offset = "0x88")]
  public static GameUtility.BooleanConfig Config_ChargeDisp;
  [Token(Token = "0x4000435")]
  [FieldOffset(Offset = "0x8C")]
  public static GameUtility.BooleanConfig Config_IsEnableShowSizeBeforeDownloading;
  [Token(Token = "0x4000436")]
  [FieldOffset(Offset = "0x90")]
  public static GameUtility.BooleanConfig Config_Adventure_SkipMovie;
  [Token(Token = "0x4000437")]
  [FieldOffset(Offset = "0x94")]
  public static GameUtility.BooleanConfig Config_Adventure_PushState;
  [Token(Token = "0x4000438")]
  [FieldOffset(Offset = "0x98")]
  public static GameUtility.BooleanConfig Config_TrophyCollectiveReceiptExp;
  [Token(Token = "0x4000439")]
  [FieldOffset(Offset = "0x9C")]
  public static GameUtility.BooleanConfig Config_IsUnitJobRankUpCommonItem;
  [Token(Token = "0x400043A")]
  [FieldOffset(Offset = "0xA0")]
  private static GameUtility.UnitShowSetting[] UnitShowSettings;
  [Token(Token = "0x400043B")]
  [FieldOffset(Offset = "0xA4")]
  public static readonly GameUtility.UnitSortModes[] UnitSortMenuItems;
  [Token(Token = "0x400043C")]
  [FieldOffset(Offset = "0xA8")]
  private static GameUtility.EScene mCurrentScene;
  [Token(Token = "0x400043D")]
  [FieldOffset(Offset = "0xAC")]
  private static Application.LogCallback mLogCallbacks;
  [Token(Token = "0x400043E")]
  [FieldOffset(Offset = "0xB0")]
  public static readonly Color32 Color32_White;
  [Token(Token = "0x400043F")]
  [FieldOffset(Offset = "0xB4")]
  public static readonly Color32 Color32_Black;
  [Token(Token = "0x4000440")]
  [FieldOffset(Offset = "0xB8")]
  private static bool mATCTextureSupport;
  [Token(Token = "0x4000441")]
  [FieldOffset(Offset = "0xB9")]
  private static bool mDXTTextureSupport;
  [Token(Token = "0x4000442")]
  [FieldOffset(Offset = "0xBA")]
  private static bool mPVRTextureSupport;
  [Token(Token = "0x4000443")]
  [FieldOffset(Offset = "0xBB")]
  private static bool mETC2TextureSupport;
  [Token(Token = "0x4000444")]
  [FieldOffset(Offset = "0xBC")]
  private static string[] mGLExtensions;
  [Token(Token = "0x4000445")]
  [FieldOffset(Offset = "0xC0")]
  private static Color mFadeInColor;
  [Token(Token = "0x4000446")]
  [FieldOffset(Offset = "0xD0")]
  private static int mLayerBG;
  [Token(Token = "0x4000447")]
  [FieldOffset(Offset = "0xD4")]
  private static int mLayerCH;
  [Token(Token = "0x4000448")]
  [FieldOffset(Offset = "0xD8")]
  private static int mLayerHidden;
  [Token(Token = "0x4000449")]
  [FieldOffset(Offset = "0xDC")]
  private static int mLayerDefault;
  [Token(Token = "0x400044A")]
  [FieldOffset(Offset = "0xE0")]
  private static int mLayerCH0;
  [Token(Token = "0x400044B")]
  [FieldOffset(Offset = "0xE4")]
  private static int mLayerCH1;
  [Token(Token = "0x400044C")]
  [FieldOffset(Offset = "0xE8")]
  private static int mLayerCH2;
  [Token(Token = "0x400044D")]
  [FieldOffset(Offset = "0xEC")]
  private static int mLayerCHBG0;
  [Token(Token = "0x400044E")]
  [FieldOffset(Offset = "0xF0")]
  private static int mLayerCHBG1;
  [Token(Token = "0x400044F")]
  [FieldOffset(Offset = "0xF4")]
  private static int mLayerCHBG2;
  [Token(Token = "0x4000450")]
  [FieldOffset(Offset = "0xF8")]
  private static int mLayerUI;
  [Token(Token = "0x4000451")]
  [FieldOffset(Offset = "0xFC")]
  private static int mLayerEffect;
  [Token(Token = "0x4000452")]
  [FieldOffset(Offset = "0x100")]
  private static bool mLayerIndexInitialized;
  [Token(Token = "0x4000453")]
  [FieldOffset(Offset = "0x104")]
  private static Texture2D mTransparentTexture;
  [Token(Token = "0x4000454")]
  [FieldOffset(Offset = "0x108")]
  private static readonly Vector3 _deformRadiusLength;
  [Token(Token = "0x4000455")]
  public const float SmallNumber = 0.0001f;
  [Token(Token = "0x4000456")]
  [FieldOffset(Offset = "0x114")]
  public static Quaternion Yaw180;
  [Token(Token = "0x4000457")]
  [FieldOffset(Offset = "0x124")]
  public static Quaternion Yaw90;
  [Token(Token = "0x4000458")]
  [FieldOffset(Offset = "0x134")]
  public static Quaternion Yaw90Inv;
  [Token(Token = "0x4000459")]
  [FieldOffset(Offset = "0x144")]
  private static int mNeverSleepCount;

  [Token(Token = "0x6000592")]
  [Address(RVA = "0xC79ED0", Offset = "0xC78CD0", VA = "0x10C79ED0")]
  public static void SetToggle(Toggle toggle, bool value)
  {
  }

  [Token(Token = "0x6000593")]
  [Address(RVA = "0xC79FD0", Offset = "0xC78DD0", VA = "0x10C79FD0")]
  public static void SetToggle(Toggle toggle, bool value, bool disableGroup)
  {
  }

  [Token(Token = "0x6000594")]
  [Address(RVA = "0xC79D70", Offset = "0xC78B70", VA = "0x10C79D70")]
  public static void SetToggleInteractable(GameObject go, bool isInteractable)
  {
  }

  [Token(Token = "0x6000595")]
  [Address(RVA = "0xC79E60", Offset = "0xC78C60", VA = "0x10C79E60")]
  public static void SetToggleInteractable(Toggle toggle, bool isInteractable)
  {
  }

  [Token(Token = "0x6000596")]
  [Address(RVA = "0xC72970", Offset = "0xC71770", VA = "0x10C72970")]
  public static void ClearPreferences()
  {
  }

  [Token(Token = "0x170000DD")]
  public static bool IsDebugBuild
  {
    [Token(Token = "0x6000597"), Address(RVA = "0xC7D750", Offset = "0xC7C550", VA = "0x10C7D750")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170000DE")]
  public static bool IsProductionBuild
  {
    [Token(Token = "0x6000598"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170000DF")]
  public static bool IsStripBuild
  {
    [Token(Token = "0x6000599"), Address(RVA = "0xC7D850", Offset = "0xC7C650", VA = "0x10C7D850")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x600059A")]
  [Address(RVA = "0xC77220", Offset = "0xC76020", VA = "0x10C77220")]
  public static StringBuilder GetStringBuilder() => (StringBuilder) null;

  [Token(Token = "0x600059B")]
  public static void ReparentGameObjects<T>(List<T> objects, Transform newParent) where T : Component
  {
  }

  [Token(Token = "0x600059C")]
  [Address(RVA = "0xC78640", Offset = "0xC77440", VA = "0x10C78640")]
  public static void ReparentGameObjects(List<GameObject> objects, Transform newParent)
  {
  }

  [Token(Token = "0x600059D")]
  [Address(RVA = "0xC7B840", Offset = "0xC7A640", VA = "0x10C7B840")]
  public static void ToggleGraphic(GameObject go, bool enable)
  {
  }

  [Token(Token = "0x170000E0")]
  public static MoveInputMethods Config_InputMethod
  {
    [Token(Token = "0x600059E"), Address(RVA = "0xC7D300", Offset = "0xC7C100", VA = "0x10C7D300")] get
    {
      return new MoveInputMethods();
    }
    [Token(Token = "0x600059F"), Address(RVA = "0xC7E920", Offset = "0xC7D720", VA = "0x10C7E920")] set
    {
    }
  }

  [Token(Token = "0x170000E1")]
  public static float Config_SoundVolume
  {
    [Token(Token = "0x60005A0"), Address(RVA = "0xC7D4C0", Offset = "0xC7C2C0", VA = "0x10C7D4C0")] get
    {
      return new float();
    }
    [Token(Token = "0x60005A1"), Address(RVA = "0xC7EAA0", Offset = "0xC7D8A0", VA = "0x10C7EAA0")] set
    {
    }
  }

  [Token(Token = "0x170000E2")]
  public static float Config_MusicVolume
  {
    [Token(Token = "0x60005A2"), Address(RVA = "0xC7D390", Offset = "0xC7C190", VA = "0x10C7D390")] get
    {
      return new float();
    }
    [Token(Token = "0x60005A3"), Address(RVA = "0xC7E9C0", Offset = "0xC7D7C0", VA = "0x10C7E9C0")] set
    {
    }
  }

  [Token(Token = "0x170000E3")]
  public static float Config_JukeboxVolume
  {
    [Token(Token = "0x60005A4"), Address(RVA = "0xC7D350", Offset = "0xC7C150", VA = "0x10C7D350")] get
    {
      return new float();
    }
    [Token(Token = "0x60005A5"), Address(RVA = "0xC7E970", Offset = "0xC7D770", VA = "0x10C7E970")] set
    {
    }
  }

  [Token(Token = "0x170000E4")]
  public static float Config_VoiceVolume
  {
    [Token(Token = "0x60005A6"), Address(RVA = "0xC7D5A0", Offset = "0xC7C3A0", VA = "0x10C7D5A0")] get
    {
      return new float();
    }
    [Token(Token = "0x60005A7"), Address(RVA = "0xC7EB30", Offset = "0xC7D930", VA = "0x10C7EB30")] set
    {
    }
  }

  [Token(Token = "0x170000E5")]
  public static string Config_OkyakusamaCode
  {
    [Token(Token = "0x60005A8"), Address(RVA = "0xC7D470", Offset = "0xC7C270", VA = "0x10C7D470")] get
    {
      return (string) null;
    }
    [Token(Token = "0x60005A9"), Address(RVA = "0xC7EA50", Offset = "0xC7D850", VA = "0x10C7EA50")] set
    {
    }
  }

  [Token(Token = "0x60005AA")]
  [Address(RVA = "0xC7D260", Offset = "0xC7C060", VA = "0x10C7D260")]
  public static string getLoginInfoRead() => (string) null;

  [Token(Token = "0x60005AB")]
  [Address(RVA = "0xC7E820", Offset = "0xC7D620", VA = "0x10C7E820")]
  public static void setLoginInfoRead(string value)
  {
  }

  [Token(Token = "0x60005AC")]
  [Address(RVA = "0xC7E5F0", Offset = "0xC7D3F0", VA = "0x10C7E5F0")]
  public static bool isLoginInfoDisplay() => new bool();

  [Token(Token = "0x60005AD")]
  [Address(RVA = "0xC77C80", Offset = "0xC76A80", VA = "0x10C77C80")]
  public static bool IsTutorialPlayed() => new bool();

  [Token(Token = "0x60005AE")]
  [Address(RVA = "0xC7A0D0", Offset = "0xC78ED0", VA = "0x10C7A0D0")]
  public static void SetTutorialPlayed()
  {
  }

  [Token(Token = "0x60005AF")]
  [Address(RVA = "0xC7D200", Offset = "0xC7C000", VA = "0x10C7D200")]
  public static string getHotDealCheck(string key) => (string) null;

  [Token(Token = "0x60005B0")]
  [Address(RVA = "0xC7E790", Offset = "0xC7D590", VA = "0x10C7E790")]
  public static void setHotDealCheck(string key, string value)
  {
  }

  [Token(Token = "0x60005B1")]
  [Address(RVA = "0xC77280", Offset = "0xC76080", VA = "0x10C77280")]
  public static bool GetUnitShowSetting(int index) => new bool();

  [Token(Token = "0x60005B2")]
  [Address(RVA = "0xC7A1D0", Offset = "0xC78FD0", VA = "0x10C7A1D0")]
  public static void SetUnitShowSetting(int index, bool value)
  {
  }

  [Token(Token = "0x60005B3")]
  [Address(RVA = "0xC78790", Offset = "0xC77590", VA = "0x10C78790")]
  public static void ResetUnitShowSetting()
  {
  }

  [Token(Token = "0x60005B4")]
  [Address(RVA = "0xC7A2A0", Offset = "0xC790A0", VA = "0x10C7A2A0")]
  public static void SortUnits(
    List<UnitData> units,
    GameUtility.UnitSortModes type,
    bool ascending,
    out int[] sortValues,
    bool outputSortedValues = false)
  {
  }

  [Token(Token = "0x60005B5")]
  [Address(RVA = "0xC7B070", Offset = "0xC79E70", VA = "0x10C7B070")]
  public static void SortUnits(
    List<UnitData> units,
    GameUtility.UnitSortModes type,
    bool ascending)
  {
  }

  [Token(Token = "0x60005B6")]
  [Address(RVA = "0xC71B30", Offset = "0xC70930", VA = "0x10C71B30")]
  public static void ApplyAvoidance(ref Vector4[] points, int iteration, float aspectRatio)
  {
  }

  [Token(Token = "0x60005B7")]
  [Address(RVA = "0xC76610", Offset = "0xC75410", VA = "0x10C76610")]
  public static string GetGameObjectPath(GameObject go) => (string) null;

  [Token(Token = "0x60005B8")]
  [Address(RVA = "0xC77E90", Offset = "0xC76C90", VA = "0x10C77E90")]
  public static Color32 ParseColor(string src) => new Color32();

  [Token(Token = "0x60005B9")]
  [Address(RVA = "0xC76470", Offset = "0xC75270", VA = "0x10C76470")]
  public static GameUtility.EScene GetCurrentScene() => new GameUtility.EScene();

  [Token(Token = "0x60005BA")]
  [Address(RVA = "0xC78E80", Offset = "0xC77C80", VA = "0x10C78E80")]
  public static void SetCurrentScene()
  {
  }

  [Token(Token = "0x60005BB")]
  [Address(RVA = "0xC72C60", Offset = "0xC71A60", VA = "0x10C72C60")]
  public static string ComposeJobIconPath(UnitParam unitparam) => (string) null;

  [Token(Token = "0x60005BC")]
  [Address(RVA = "0xC768C0", Offset = "0xC756C0", VA = "0x10C768C0")]
  public static string GetQuestMissionTextID(QuestBonusObjective bonus) => (string) null;

  [Token(Token = "0x60005BD")]
  [Address(RVA = "0xC76820", Offset = "0xC75620", VA = "0x10C76820")]
  public static string GetQuestMissionProgressTextID(QuestBonusObjective bonus, bool isAchievable)
  {
    return (string) null;
  }

  [Token(Token = "0x60005BE")]
  [Address(RVA = "0xC72D30", Offset = "0xC71B30", VA = "0x10C72D30")]
  public static string ComposeQuestBonusObjectiveText(QuestBonusObjective bonus) => (string) null;

  [Token(Token = "0x60005BF")]
  [Address(RVA = "0xC741B0", Offset = "0xC72FB0", VA = "0x10C741B0")]
  public static string ComposeQuestMissionProgressText(
    QuestBonusObjective bonus,
    int missions_val,
    bool isAchievable)
  {
    return (string) null;
  }

  [Token(Token = "0x60005C0")]
  [Address(RVA = "0xC72B10", Offset = "0xC71910", VA = "0x10C72B10")]
  public static string ComposeCharacterQuestMainUnitConditionText(UnitData unit, QuestParam param)
  {
    return (string) null;
  }

  [Token(Token = "0x60005C1")]
  [Address(RVA = "0xC777B0", Offset = "0xC765B0", VA = "0x10C777B0")]
  public static double InternalToMapHeight(double InternalHeight) => new double();

  [Token(Token = "0x60005C2")]
  [Address(RVA = "0xC777A0", Offset = "0xC765A0", VA = "0x10C777A0")]
  public static float InternalToMapHeight(float InternalHeight) => new float();

  [Token(Token = "0x60005C3")]
  [Address(RVA = "0xC77E80", Offset = "0xC76C80", VA = "0x10C77E80")]
  public static double MapToInternalHeight(double MapHeight) => new double();

  [Token(Token = "0x60005C4")]
  [Address(RVA = "0xC77E70", Offset = "0xC76C70", VA = "0x10C77E70")]
  public static float MapToInternalHeight(float MapHeight) => new float();

  [Token(Token = "0x60005C5")]
  [Address(RVA = "0xC780E0", Offset = "0xC76EE0", VA = "0x10C780E0")]
  public static Vector3 RaycastGround(Vector3 position) => new Vector3();

  [Token(Token = "0x60005C6")]
  [Address(RVA = "0xC72370", Offset = "0xC71170", VA = "0x10C72370")]
  public static float CalcHeight(float x, float y) => new float();

  [Token(Token = "0x60005C7")]
  [Address(RVA = "0xC781F0", Offset = "0xC76FF0", VA = "0x10C781F0")]
  public static Vector3 RaycastGround(Vector2 position) => new Vector3();

  [Token(Token = "0x60005C8")]
  [Address(RVA = "0xC78280", Offset = "0xC77080", VA = "0x10C78280")]
  public static float RaycastGround(float x, float z) => new float();

  [Token(Token = "0x60005C9")]
  [Address(RVA = "0xC722B0", Offset = "0xC710B0", VA = "0x10C722B0")]
  public static float CalcDistance2D(Vector3 a, Vector3 b) => new float();

  [Token(Token = "0x60005CA")]
  [Address(RVA = "0xC72210", Offset = "0xC71010", VA = "0x10C72210")]
  public static float CalcDistance2D(Vector3 a) => new float();

  [Token(Token = "0x60005CB")]
  [Address(RVA = "0xC774F0", Offset = "0xC762F0", VA = "0x10C774F0")]
  private static void HandleLog(string logString, string stackTrace, LogType type)
  {
  }

  [Token(Token = "0x60005CC")]
  [Address(RVA = "0xC78300", Offset = "0xC77100", VA = "0x10C78300")]
  public static void RegisterLogCallback(Application.LogCallback callback)
  {
  }

  [Token(Token = "0x60005CD")]
  [Address(RVA = "0xC7B960", Offset = "0xC7A760", VA = "0x10C7B960")]
  public static void UnregisterLogCallback(Application.LogCallback callback)
  {
  }

  [Token(Token = "0x60005CE")]
  [Address(RVA = "0xC76100", Offset = "0xC74F00", VA = "0x10C76100")]
  public static float EvaluateCurveLooped(AnimationCurve curve, float time) => new float();

  [Token(Token = "0x60005CF")]
  [Address(RVA = "0xC784D0", Offset = "0xC772D0", VA = "0x10C784D0")]
  public static void RemoveDuplicatedMainCamera()
  {
  }

  [Token(Token = "0x170000E6")]
  public static bool IsATCTextureSupported
  {
    [Token(Token = "0x60005D0"), Address(RVA = "0xC7D6B0", Offset = "0xC7C4B0", VA = "0x10C7D6B0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170000E7")]
  public static bool IsDXTTextureSupported
  {
    [Token(Token = "0x60005D1"), Address(RVA = "0xC7D700", Offset = "0xC7C500", VA = "0x10C7D700")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170000E8")]
  public static bool IsPVRTextureSupported
  {
    [Token(Token = "0x60005D2"), Address(RVA = "0xC7D7D0", Offset = "0xC7C5D0", VA = "0x10C7D7D0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170000E9")]
  public static bool IsETC2TextureSupported
  {
    [Token(Token = "0x60005D3"), Address(RVA = "0xC7D790", Offset = "0xC7C590", VA = "0x10C7D790")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x60005D4")]
  [Address(RVA = "0xC78000", Offset = "0xC76E00", VA = "0x10C78000")]
  public static void PrintGLExtensions()
  {
  }

  [Token(Token = "0x60005D5")]
  [Address(RVA = "0xC77BB0", Offset = "0xC769B0", VA = "0x10C77BB0")]
  public static bool IsGLExtensionSupported(string extName) => new bool();

  [Token(Token = "0x60005D6")]
  [Address(RVA = "0xC720C0", Offset = "0xC70EC0", VA = "0x10C720C0")]
  private static void CacheGLExtensions()
  {
  }

  [Token(Token = "0x60005D7")]
  [Address(RVA = "0xC7BA90", Offset = "0xC7A890", VA = "0x10C7BA90")]
  public static bool ValidateAnimator(Animator animator) => new bool();

  [Token(Token = "0x60005D8")]
  public static void EnableBehaviour<T>(GameObject go, bool enable) where T : Behaviour
  {
  }

  [Token(Token = "0x60005D9")]
  public static void EnableBehaviour<T>(Component go, bool enable) where T : Behaviour
  {
  }

  [Token(Token = "0x60005DA")]
  public static T GetArrayElementSafe<T>(T[] list, int index) => (T) null;

  [Token(Token = "0x170000EA")]
  public static bool IsScreenFading
  {
    [Token(Token = "0x60005DB"), Address(RVA = "0xC7D820", Offset = "0xC7C620", VA = "0x10C7D820")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x60005DC")]
  [Address(RVA = "0xC76280", Offset = "0xC75080", VA = "0x10C76280")]
  public static void FadeIn(float time)
  {
  }

  [Token(Token = "0x60005DD")]
  [Address(RVA = "0xC76300", Offset = "0xC75100", VA = "0x10C76300")]
  public static void FadeOut(float time)
  {
  }

  [Token(Token = "0x60005DE")]
  [Address(RVA = "0xC76660", Offset = "0xC75460", VA = "0x10C76660")]
  private static int GetLayerIndex(string name) => new int();

  [Token(Token = "0x60005DF")]
  [Address(RVA = "0xC77580", Offset = "0xC76380", VA = "0x10C77580")]
  public static void InitializeLayerIndices()
  {
  }

  [Token(Token = "0x170000EB")]
  public static int LayerDefault
  {
    [Token(Token = "0x60005E0"), Address(RVA = "0xC7DD40", Offset = "0xC7CB40", VA = "0x10C7DD40")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000EC")]
  public static int LayerBG
  {
    [Token(Token = "0x60005E1"), Address(RVA = "0xC7D8C0", Offset = "0xC7C6C0", VA = "0x10C7D8C0")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000ED")]
  public static int LayerCH
  {
    [Token(Token = "0x60005E2"), Address(RVA = "0xC7DCB0", Offset = "0xC7CAB0", VA = "0x10C7DCB0")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000EE")]
  public static int LayerHidden
  {
    [Token(Token = "0x60005E3"), Address(RVA = "0xC7DE60", Offset = "0xC7CC60", VA = "0x10C7DE60")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000EF")]
  public static int LayerUI
  {
    [Token(Token = "0x60005E4"), Address(RVA = "0xC7E300", Offset = "0xC7D100", VA = "0x10C7E300")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000F0")]
  public static int LayerEffect
  {
    [Token(Token = "0x60005E5"), Address(RVA = "0xC7DDD0", Offset = "0xC7CBD0", VA = "0x10C7DDD0")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000F1")]
  public static int LayerCH0
  {
    [Token(Token = "0x60005E6"), Address(RVA = "0xC7D950", Offset = "0xC7C750", VA = "0x10C7D950")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000F2")]
  public static int LayerCH1
  {
    [Token(Token = "0x60005E7"), Address(RVA = "0xC7D9E0", Offset = "0xC7C7E0", VA = "0x10C7D9E0")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000F3")]
  public static int LayerCH2
  {
    [Token(Token = "0x60005E8"), Address(RVA = "0xC7DA70", Offset = "0xC7C870", VA = "0x10C7DA70")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000F4")]
  public static int LayerCHBG0
  {
    [Token(Token = "0x60005E9"), Address(RVA = "0xC7DB00", Offset = "0xC7C900", VA = "0x10C7DB00")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000F5")]
  public static int LayerCHBG1
  {
    [Token(Token = "0x60005EA"), Address(RVA = "0xC7DB90", Offset = "0xC7C990", VA = "0x10C7DB90")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000F6")]
  public static int LayerCHBG2
  {
    [Token(Token = "0x60005EB"), Address(RVA = "0xC7DC20", Offset = "0xC7CA20", VA = "0x10C7DC20")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000F7")]
  public static int LayerMaskEffect
  {
    [Token(Token = "0x60005EC"), Address(RVA = "0xC7E090", Offset = "0xC7CE90", VA = "0x10C7E090")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000F8")]
  public static int LayerMaskCH
  {
    [Token(Token = "0x60005ED"), Address(RVA = "0xC7DFC0", Offset = "0xC7CDC0", VA = "0x10C7DFC0")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000F9")]
  public static int LayerMaskBG
  {
    [Token(Token = "0x60005EE"), Address(RVA = "0xC7DEF0", Offset = "0xC7CCF0", VA = "0x10C7DEF0")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000FA")]
  public static int LayerMaskHidden
  {
    [Token(Token = "0x60005EF"), Address(RVA = "0xC7E160", Offset = "0xC7CF60", VA = "0x10C7E160")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000FB")]
  public static int LayerMaskUI
  {
    [Token(Token = "0x60005F0"), Address(RVA = "0xC7E230", Offset = "0xC7D030", VA = "0x10C7E230")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000FC")]
  public static Texture2D TransparentTexture
  {
    [Token(Token = "0x60005F1"), Address(RVA = "0xC7E490", Offset = "0xC7D290", VA = "0x10C7E490")] get
    {
      return (Texture2D) null;
    }
  }

  [Token(Token = "0x60005F2")]
  public static void DeactivateActiveChildComponents<T>(Component parent)
  {
  }

  [Token(Token = "0x60005F3")]
  [Address(RVA = "0xC75B90", Offset = "0xC74990", VA = "0x10C75B90")]
  public static Vector3 DeformPosition(Vector3 pos, float zOffset) => new Vector3();

  [Token(Token = "0x60005F4")]
  public static T GetComponentInAllChildren<T>(GameObject go) where T : Component => (T) null;

  [Token(Token = "0x60005F5")]
  [Address(RVA = "0xC79450", Offset = "0xC78250", VA = "0x10C79450")]
  public static void SetLayer(GameObject go, int layer, bool changeChildren)
  {
  }

  [Token(Token = "0x60005F6")]
  [Address(RVA = "0xC79540", Offset = "0xC78340", VA = "0x10C79540")]
  public static void SetLayer(Component go, int layer, bool changeChildren)
  {
  }

  [Token(Token = "0x60005F7")]
  [Address(RVA = "0xC79190", Offset = "0xC77F90", VA = "0x10C79190")]
  public static void SetGameObjectActive(GameObject obj, bool active)
  {
  }

  [Token(Token = "0x60005F8")]
  [Address(RVA = "0xC79200", Offset = "0xC78000", VA = "0x10C79200")]
  public static void SetGameObjectActive(Component go, bool active)
  {
  }

  [Token(Token = "0x60005F9")]
  [Address(RVA = "0xC75F00", Offset = "0xC74D00", VA = "0x10C75F00")]
  public static void DestroyGameObjects(GameObject[] list)
  {
  }

  [Token(Token = "0x60005FA")]
  public static void DestroyGameObjects<T>(T[] list) where T : Component
  {
  }

  [Token(Token = "0x60005FB")]
  [Address(RVA = "0xC76000", Offset = "0xC74E00", VA = "0x10C76000")]
  public static void DestroyGameObjects(List<GameObject> list)
  {
  }

  [Token(Token = "0x60005FC")]
  public static void DestroyGameObjects<T>(List<T> list) where T : Component
  {
  }

  [Token(Token = "0x60005FD")]
  [Address(RVA = "0xC75E70", Offset = "0xC74C70", VA = "0x10C75E70")]
  public static void DestroyGameObject(GameObject go)
  {
  }

  [Token(Token = "0x60005FE")]
  [Address(RVA = "0xC75DE0", Offset = "0xC74BE0", VA = "0x10C75DE0")]
  public static void DestroyGameObject(Component go)
  {
  }

  [Token(Token = "0x60005FF")]
  [Address(RVA = "0xC77A90", Offset = "0xC76890", VA = "0x10C77A90")]
  public static bool IsAnimatorRunning(GameObject go) => new bool();

  [Token(Token = "0x6000600")]
  [Address(RVA = "0xC77920", Offset = "0xC76720", VA = "0x10C77920")]
  public static bool IsAnimatorRunning(Component go) => new bool();

  [Token(Token = "0x6000601")]
  [Address(RVA = "0xC72A90", Offset = "0xC71890", VA = "0x10C72A90")]
  public static bool CompareAnimatorStateName(GameObject go, string stateName) => new bool();

  [Token(Token = "0x6000602")]
  [Address(RVA = "0xC729C0", Offset = "0xC717C0", VA = "0x10C729C0")]
  public static bool CompareAnimatorStateName(Component go, string stateName) => new bool();

  [Token(Token = "0x6000603")]
  [Address(RVA = "0xC78B40", Offset = "0xC77940", VA = "0x10C78B40")]
  public static void SetAnimatorTrigger(GameObject go, string trigger)
  {
  }

  [Token(Token = "0x6000604")]
  [Address(RVA = "0xC78BF0", Offset = "0xC779F0", VA = "0x10C78BF0")]
  public static void SetAnimatorTrigger(Component go, string trigger)
  {
  }

  [Token(Token = "0x6000605")]
  [Address(RVA = "0xC78A90", Offset = "0xC77890", VA = "0x10C78A90")]
  public static void SetAnimatorBool(Component go, string name, bool value)
  {
  }

  [Token(Token = "0x6000606")]
  [Address(RVA = "0xC78D20", Offset = "0xC77B20", VA = "0x10C78D20")]
  public static void SetButtonIntaractable(GameObject go, bool isInteractable)
  {
  }

  [Token(Token = "0x6000607")]
  [Address(RVA = "0xC78E10", Offset = "0xC77C10", VA = "0x10C78E10")]
  public static void SetButtonIntaractable(Button button, bool isInteractable)
  {
  }

  [Token(Token = "0x6000608")]
  [Address(RVA = "0xC79B80", Offset = "0xC78980", VA = "0x10C79B80")]
  public static void SetText(GameObject go, string msg, bool is_color = false, Color new_color = default (Color))
  {
  }

  [Token(Token = "0x6000609")]
  [Address(RVA = "0xC79CD0", Offset = "0xC78AD0", VA = "0x10C79CD0")]
  public static void SetText(UnityEngine.UI.Text go, string msg, bool is_color = false, Color new_color = default (Color))
  {
  }

  [Token(Token = "0x600060A")]
  [Address(RVA = "0xC79AE0", Offset = "0xC788E0", VA = "0x10C79AE0")]
  public static void SetText(BitmapText go, string msg, bool is_color = false, Color new_color = default (Color))
  {
  }

  [Token(Token = "0x600060B")]
  [Address(RVA = "0xC79930", Offset = "0xC78730", VA = "0x10C79930")]
  public static void SetTextColor(GameObject go, Color new_color)
  {
  }

  [Token(Token = "0x600060C")]
  [Address(RVA = "0xC798B0", Offset = "0xC786B0", VA = "0x10C798B0")]
  public static void SetTextColor(UnityEngine.UI.Text go, Color new_color)
  {
  }

  [Token(Token = "0x600060D")]
  [Address(RVA = "0xC79A60", Offset = "0xC78860", VA = "0x10C79A60")]
  public static void SetTextColor(BitmapText go, Color new_color)
  {
  }

  [Token(Token = "0x600060E")]
  [Address(RVA = "0xC79750", Offset = "0xC78550", VA = "0x10C79750")]
  public static void SetSprite(GameObject go, Sprite sprite)
  {
  }

  [Token(Token = "0x600060F")]
  [Address(RVA = "0xC79840", Offset = "0xC78640", VA = "0x10C79840")]
  public static void SetSprite(Image img, Sprite sprite)
  {
  }

  [Token(Token = "0x6000610")]
  [Address(RVA = "0xC79320", Offset = "0xC78120", VA = "0x10C79320")]
  public static void SetImageArray(GameObject _go, int _index)
  {
  }

  [Token(Token = "0x6000611")]
  [Address(RVA = "0xC79280", Offset = "0xC78080", VA = "0x10C79280")]
  public static void SetImageArray(ImageArray _img, int _index)
  {
  }

  [Token(Token = "0x6000612")]
  public static bool IsWithIn<T>(T[] _list, int _index) => new bool();

  [Token(Token = "0x6000613")]
  public static bool IsWithIn<T>(T val, T min, T max) where T : IComparable => new bool();

  [Token(Token = "0x6000614")]
  public static bool ContainDictionary<T>(Dictionary<string, T> _dict, string _str) => new bool();

  [Token(Token = "0x6000615")]
  public static T GetContainDictionary<T>(Dictionary<string, T> _dict, string _str) => (T) null;

  [Token(Token = "0x6000616")]
  public static void RemoveComponent<T>(GameObject go) where T : Component
  {
  }

  [Token(Token = "0x6000617")]
  public static T RequireComponent<T>(GameObject go) where T : Component => (T) null;

  [Token(Token = "0x6000618")]
  [Address(RVA = "0xC7B500", Offset = "0xC7A300", VA = "0x10C7B500")]
  public static GameObject SpawnParticle(
    GameObject prefab,
    Vector3 position,
    Quaternion rotation,
    GameObject parentScene)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x6000619")]
  [Address(RVA = "0xC7B360", Offset = "0xC7A160", VA = "0x10C7B360")]
  public static GameObject SpawnParticle(
    GameObject prefab,
    Transform position,
    GameObject parentScene)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x600061A")]
  [Address(RVA = "0xC7B630", Offset = "0xC7A430", VA = "0x10C7B630")]
  public static GameObject SpawnParticle(
    SkillEffect.EffectElement[] effect_elements,
    Vector3 position,
    Quaternion rotation,
    GameObject parentScene)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x600061B")]
  [Address(RVA = "0xC7B770", Offset = "0xC7A570", VA = "0x10C7B770")]
  public static void StopEmitters(GameObject obj)
  {
  }

  [Token(Token = "0x600061C")]
  [Address(RVA = "0xC77D00", Offset = "0xC76B00", VA = "0x10C77D00")]
  public static LoadRequest LoadResourceAsyncChecked(string path) => (LoadRequest) null;

  [Token(Token = "0x600061D")]
  public static LoadRequest LoadResourceAsyncChecked<T>(string path) => (LoadRequest) null;

  [Token(Token = "0x600061E")]
  [Address(RVA = "0xC77E20", Offset = "0xC76C20", VA = "0x10C77E20")]
  public static LoadRequest LoadResourceAsync(string path) => (LoadRequest) null;

  [Token(Token = "0x600061F")]
  public static LoadRequest LoadResourceAsync<T>(string path) => (LoadRequest) null;

  [Token(Token = "0x6000620")]
  [Address(RVA = "0xC78740", Offset = "0xC77540", VA = "0x10C78740")]
  public static void RequestScene(string name)
  {
  }

  [Token(Token = "0x6000621")]
  [Address(RVA = "0xC789E0", Offset = "0xC777E0", VA = "0x10C789E0")]
  public static void SetAnimationClip(Animation animation, AnimationClip clip)
  {
  }

  [Token(Token = "0x6000622")]
  [Address(RVA = "0xC78710", Offset = "0xC77510", VA = "0x10C78710")]
  public static void Reparent(Transform child, Transform newParent)
  {
  }

  [Token(Token = "0x6000623")]
  [Address(RVA = "0xC766F0", Offset = "0xC754F0", VA = "0x10C766F0")]
  public static string GetPlatformID() => (string) null;

  [Token(Token = "0x6000624")]
  [Address(RVA = "0xC756B0", Offset = "0xC744B0", VA = "0x10C756B0")]
  public static void CopyTransform(Transform dest, Transform src)
  {
  }

  [Token(Token = "0x6000625")]
  [Address(RVA = "0xC777C0", Offset = "0xC765C0", VA = "0x10C777C0")]
  public static void InterpTransform(Transform tr, Transform start, Transform end, float t)
  {
  }

  [Token(Token = "0x6000626")]
  [Address(RVA = "0xC77150", Offset = "0xC75F50", VA = "0x10C77150")]
  public static RectTransform GetRectTransform(GameObject obj) => (RectTransform) null;

  [Token(Token = "0x6000627")]
  [Address(RVA = "0xC771B0", Offset = "0xC75FB0", VA = "0x10C771B0")]
  public static RectTransform GetRectTransform(Component obj) => (RectTransform) null;

  [Token(Token = "0x6000628")]
  [Address(RVA = "0xC7D110", Offset = "0xC7BF10", VA = "0x10C7D110")]
  public static Transform findChildRecursively(Transform parent, string name) => (Transform) null;

  [Token(Token = "0x6000629")]
  public static void swap<T>(ref T a, ref T b)
  {
  }

  [Token(Token = "0x170000FD")]
  public static float GUIScale
  {
    [Token(Token = "0x600062A"), Address(RVA = "0xC7D680", Offset = "0xC7C480", VA = "0x10C7D680")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x170000FE")]
  public static float ScaledScreenWidth
  {
    [Token(Token = "0x600062B"), Address(RVA = "0xC7E410", Offset = "0xC7D210", VA = "0x10C7E410")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x170000FF")]
  public static float ScaledScreenHeight
  {
    [Token(Token = "0x600062C"), Address(RVA = "0xC7E390", Offset = "0xC7D190", VA = "0x10C7E390")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x600062D")]
  [Address(RVA = "0xC788E0", Offset = "0xC776E0", VA = "0x10C788E0")]
  public static void ScaleGUI(float scale = 1f)
  {
  }

  [Token(Token = "0x600062E")]
  public static string CalcResourceSizeSum<T>() => (string) null;

  [Token(Token = "0x600062F")]
  [Address(RVA = "0xC75A40", Offset = "0xC74840", VA = "0x10C75A40")]
  public static string CreateUUID() => (string) null;

  [Token(Token = "0x6000630")]
  [Address(RVA = "0xC7B8C0", Offset = "0xC7A6C0", VA = "0x10C7B8C0")]
  public static DateTime UnixtimeToLocalTime(long unixtime) => new DateTime();

  [Token(Token = "0x6000631")]
  [Address(RVA = "0xC796B0", Offset = "0xC784B0", VA = "0x10C796B0")]
  public static void SetNeverSleep()
  {
  }

  [Token(Token = "0x6000632")]
  [Address(RVA = "0xC790A0", Offset = "0xC77EA0", VA = "0x10C790A0")]
  public static void SetDefaultSleepSetting()
  {
  }

  [Token(Token = "0x6000633")]
  [Address(RVA = "0xC7BA30", Offset = "0xC7A830", VA = "0x10C7BA30")]
  private static void UpdateSetting()
  {
  }

  [Token(Token = "0x6000634")]
  [Address(RVA = "0xC76350", Offset = "0xC75150", VA = "0x10C76350")]
  public static void ForceSetDefaultSleepSetting()
  {
  }

  [Token(Token = "0x6000635")]
  public static byte[] Object2Binary<T>(T data, bool isCompress = false) => (byte[]) null;

  [Token(Token = "0x6000636")]
  public static bool Binary2Object<T>(out T buffer, byte[] data, bool isCompress = false)
  {
    return new bool();
  }

  [Token(Token = "0x6000637")]
  [Address(RVA = "0xC773E0", Offset = "0xC761E0", VA = "0x10C773E0")]
  public static string HalfNum2FullNum(string str) => (string) null;

  [Token(Token = "0x6000638")]
  [Address(RVA = "0xC76560", Offset = "0xC75360", VA = "0x10C76560")]
  public static string GetExternalLocalizedText(string sheetName, string iname, string columnName)
  {
    return (string) null;
  }

  [Token(Token = "0x6000639")]
  public static T GetCustomAttribute<T>(object target, bool inherit) where T : Attribute
  {
    return (T) null;
  }

  [Token(Token = "0x600063A")]
  [Address(RVA = "0xC71F50", Offset = "0xC70D50", VA = "0x10C71F50")]
  public static string ByteSizeToString(long byteSize, bool forceMB, bool ceiling = true)
  {
    return (string) null;
  }

  [Token(Token = "0x600063B")]
  [Address(RVA = "0xC75C90", Offset = "0xC74A90", VA = "0x10C75C90")]
  public static void DestroyChildGameObjects(GameObject go_parent, List<GameObject> go_ignore_lists = null)
  {
  }

  [Token(Token = "0x600063C")]
  public static void DestroyChildGameObjects<T>(
    GameObject go_parent,
    List<GameObject> go_ignore_lists = null)
  {
  }

  [Token(Token = "0x600063D")]
  [Address(RVA = "0xC763A0", Offset = "0xC751A0", VA = "0x10C763A0")]
  public static int GetBitCount(long bits) => new int();

  [Token(Token = "0x600063E")]
  [Address(RVA = "0xC72860", Offset = "0xC71660", VA = "0x10C72860")]
  public static int CalcRateRoundUp(long value, long percent) => new int();

  [Token(Token = "0x600063F")]
  [Address(RVA = "0xC72830", Offset = "0xC71630", VA = "0x10C72830")]
  public static int CalcRateRoundDown(long value, long percent) => new int();

  [Token(Token = "0x6000640")]
  [Address(RVA = "0xC721D0", Offset = "0xC70FD0", VA = "0x10C721D0")]
  public static int CalcAddRateRoundUp(long value, long addPercent) => new int();

  [Token(Token = "0x6000641")]
  [Address(RVA = "0xC72190", Offset = "0xC70F90", VA = "0x10C72190")]
  public static int CalcAddRateRoundDown(long value, long addPercent) => new int();

  [Token(Token = "0x6000642")]
  [Address(RVA = "0xC72930", Offset = "0xC71730", VA = "0x10C72930")]
  public static int CalcSubRateRoundUp(long value, long subPercent) => new int();

  [Token(Token = "0x6000643")]
  [Address(RVA = "0xC728F0", Offset = "0xC716F0", VA = "0x10C728F0")]
  public static int CalcSubRateRoundDown(long value, long subPercent) => new int();

  [Token(Token = "0x6000644")]
  [Address(RVA = "0xC75860", Offset = "0xC74660", VA = "0x10C75860")]
  public static bool CreateRenderTexture(
    Vector2 size,
    ref RenderTexture rt,
    int depthBuffer = 16,
    RenderTextureFormat format = RenderTextureFormat.Default)
  {
    return new bool();
  }

  [Token(Token = "0x6000645")]
  [Address(RVA = "0xC75730", Offset = "0xC74530", VA = "0x10C75730")]
  public static RenderTexture CreateRenderTexture(
    Vector2 size,
    int depthBuffer,
    RenderTextureFormat format)
  {
    return (RenderTexture) null;
  }

  [Token(Token = "0x6000646")]
  [Address(RVA = "0xC78450", Offset = "0xC77250", VA = "0x10C78450")]
  public static void ReleaseRenderTexture(ref RenderTexture renderTexture)
  {
  }

  [Token(Token = "0x6000647")]
  [Address(RVA = "0xC7BB10", Offset = "0xC7A910", VA = "0x10C7BB10")]
  static GameUtility()
  {
  }

  [Token(Token = "0x20000ED")]
  public enum eTimeSplit
  {
    [Token(Token = "0x400045B")] Hour,
    [Token(Token = "0x400045C")] Min,
    [Token(Token = "0x400045D")] MAX,
  }

  [Token(Token = "0x20000EE")]
  public class BooleanConfig
  {
    [Token(Token = "0x400045E")]
    [FieldOffset(Offset = "0x8")]
    private string mKey;
    [Token(Token = "0x400045F")]
    [FieldOffset(Offset = "0xC")]
    private bool mDefaultValue;

    [Token(Token = "0x6000648")]
    [Address(RVA = "0x305760", Offset = "0x304560", VA = "0x10305760")]
    public BooleanConfig(string configName, bool defaultValue)
    {
    }

    [Token(Token = "0x17000100")]
    public bool Value
    {
      [Token(Token = "0x6000649"), Address(RVA = "0xD54FE0", Offset = "0xD53DE0", VA = "0x10D54FE0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600064A"), Address(RVA = "0xD54F80", Offset = "0xD53D80", VA = "0x10D54F80")] set
      {
      }
    }
  }

  [Token(Token = "0x20000EF")]
  public class BooleanConfigWithEnvBitFlagCheck : GameUtility.BooleanConfig
  {
    [Token(Token = "0x4000460")]
    [FieldOffset(Offset = "0x10")]
    private Gsc.App.Environment.EnvironmentFlagBit mBitFlagCondition;
    [Token(Token = "0x4000461")]
    [FieldOffset(Offset = "0x14")]
    private bool mForcedBoolValue;

    [Token(Token = "0x600064B")]
    [Address(RVA = "0xD54E70", Offset = "0xD53C70", VA = "0x10D54E70")]
    public BooleanConfigWithEnvBitFlagCheck(
      string configName,
      bool defaultValue,
      Gsc.App.Environment.EnvironmentFlagBit bitFlagCondition,
      bool forcedBoolValue)
    {
    }

    [Token(Token = "0x17000101")]
    public new bool Value
    {
      [Token(Token = "0x600064C"), Address(RVA = "0xD54EB0", Offset = "0xD53CB0", VA = "0x10D54EB0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600064D"), Address(RVA = "0xD54F80", Offset = "0xD53D80", VA = "0x10D54F80")] set
      {
      }
    }
  }

  [Token(Token = "0x20000F0")]
  private struct UnitShowSetting
  {
    [Token(Token = "0x4000462")]
    [FieldOffset(Offset = "0x0")]
    public string key;
    [Token(Token = "0x4000463")]
    [FieldOffset(Offset = "0x4")]
    public int on;
  }

  [Token(Token = "0x20000F1")]
  public enum UnitShowSettingTypes
  {
    [Token(Token = "0x4000465")] FILTER_FIRE,
    [Token(Token = "0x4000466")] FILTER_WATER,
    [Token(Token = "0x4000467")] FILTER_WIND,
    [Token(Token = "0x4000468")] FILTER_THUNDER,
    [Token(Token = "0x4000469")] FILTER_SHINE,
    [Token(Token = "0x400046A")] FILTER_DARK,
    [Token(Token = "0x400046B")] FILTER_ZENEI,
    [Token(Token = "0x400046C")] FILTER_TYUEI,
    [Token(Token = "0x400046D")] FILTER_KOUEI,
    [Token(Token = "0x400046E")] FILTER_RARE1,
    [Token(Token = "0x400046F")] FILTER_RARE2,
    [Token(Token = "0x4000470")] FILTER_RARE3,
    [Token(Token = "0x4000471")] FILTER_RARE4,
    [Token(Token = "0x4000472")] FILTER_RARE5,
    [Token(Token = "0x4000473")] FILTER_RARE6,
    [Token(Token = "0x4000474")] SORT_SYOJUN,
    [Token(Token = "0x4000475")] SORT_KOUJUN,
    [Token(Token = "0x4000476")] SORT_LEVEL,
    [Token(Token = "0x4000477")] SORT_FAVORITE,
    [Token(Token = "0x4000478")] SORT_JOBRANK,
    [Token(Token = "0x4000479")] SORT_HP,
    [Token(Token = "0x400047A")] SORT_ATK,
    [Token(Token = "0x400047B")] SORT_DEF,
    [Token(Token = "0x400047C")] SORT_MAG,
    [Token(Token = "0x400047D")] SORT_MND,
    [Token(Token = "0x400047E")] SORT_SPD,
    [Token(Token = "0x400047F")] SORT_TOTAL,
    [Token(Token = "0x4000480")] SORT_AWAKE,
    [Token(Token = "0x4000481")] SORT_COMBINATION,
  }

  [Token(Token = "0x20000F2")]
  public enum UnitSortModes
  {
    [Token(Token = "0x4000483")] Time,
    [Token(Token = "0x4000484")] Level,
    [Token(Token = "0x4000485")] JobRank,
    [Token(Token = "0x4000486")] HP,
    [Token(Token = "0x4000487")] Atk,
    [Token(Token = "0x4000488")] Def,
    [Token(Token = "0x4000489")] Mag,
    [Token(Token = "0x400048A")] Mnd,
    [Token(Token = "0x400048B")] Rec,
    [Token(Token = "0x400048C")] Spd,
    [Token(Token = "0x400048D")] Total,
    [Token(Token = "0x400048E")] Awake,
    [Token(Token = "0x400048F")] Combination,
    [Token(Token = "0x4000490")] Rarity,
    [Token(Token = "0x4000491")] Name,
    [Token(Token = "0x4000492")] Dex,
    [Token(Token = "0x4000493")] Cri,
    [Token(Token = "0x4000494")] Luk,
    [Token(Token = "0x4000495")] Piece,
  }

  [Token(Token = "0x20000F3")]
  public enum EScene
  {
    [Token(Token = "0x4000497")] UNKNOWN,
    [Token(Token = "0x4000498")] BATTLE,
    [Token(Token = "0x4000499")] BATTLE_MULTI,
    [Token(Token = "0x400049A")] HOME,
    [Token(Token = "0x400049B")] HOME_MULTI,
    [Token(Token = "0x400049C")] TITLE,
    [Token(Token = "0x400049D")] MULTI_TOWER,
  }
}
