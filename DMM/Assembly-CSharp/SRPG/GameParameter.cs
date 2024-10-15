// Decompiled with JetBrains decompiler
// Type: SRPG.GameParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F31")]
  [AddComponentMenu("UI/Game Parameter")]
  public class GameParameter : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x4002F5C")]
    private const int PARAMETER_CATEGORY_SIZE = 100;
    [Token(Token = "0x4002F5D")]
    [FieldOffset(Offset = "0x0")]
    public static List<GameParameter> Instances;
    [Token(Token = "0x4002F5E")]
    [FieldOffset(Offset = "0xC")]
    public GameParameter.ParameterTypes ParameterType;
    [Token(Token = "0x4002F5F")]
    [FieldOffset(Offset = "0x10")]
    public int InstanceType;
    [Token(Token = "0x4002F60")]
    [FieldOffset(Offset = "0x14")]
    public int ViewType;
    [Token(Token = "0x4002F61")]
    [FieldOffset(Offset = "0x18")]
    public int Index;
    [Token(Token = "0x4002F62")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject[] SerializeGameObject;
    [Token(Token = "0x4002F63")]
    [FieldOffset(Offset = "0x20")]
    private Slider mSlider;
    [Token(Token = "0x4002F64")]
    [FieldOffset(Offset = "0x24")]
    private Text mText;
    [Token(Token = "0x4002F65")]
    [FieldOffset(Offset = "0x28")]
    private InputField mInputField;
    [Token(Token = "0x4002F66")]
    [FieldOffset(Offset = "0x2C")]
    private Animator mAnimator;
    [Token(Token = "0x4002F67")]
    [FieldOffset(Offset = "0x30")]
    private RawImage mImage;
    [Token(Token = "0x4002F68")]
    [FieldOffset(Offset = "0x34")]
    private ImageArray mImageArray;
    [Token(Token = "0x4002F69")]
    [FieldOffset(Offset = "0x38")]
    private Coroutine mUpdateCoroutine;
    [Token(Token = "0x4002F6A")]
    [FieldOffset(Offset = "0x3C")]
    private float mNextUpdateTime;
    [Token(Token = "0x4002F6B")]
    [FieldOffset(Offset = "0x40")]
    private string mDefaultValue;
    [Token(Token = "0x4002F6C")]
    [FieldOffset(Offset = "0x44")]
    private Vector2 mDefaultRangeValue;
    [Token(Token = "0x4002F6D")]
    [FieldOffset(Offset = "0x4C")]
    private Texture mDefaultImage;
    [Token(Token = "0x4002F6E")]
    [FieldOffset(Offset = "0x50")]
    private Sprite mDefaultSprite;
    [Token(Token = "0x4002F6F")]
    [FieldOffset(Offset = "0x54")]
    private bool mUpdate;
    [Token(Token = "0x4002F70")]
    [FieldOffset(Offset = "0x55")]
    private bool mIsEmptyGO;
    [Token(Token = "0x4002F71")]
    [FieldOffset(Offset = "0x56")]
    private bool mStarted;

    [Token(Token = "0x6003F70")]
    [Address(RVA = "0x11804E0", Offset = "0x117F2E0", VA = "0x111804E0")]
    private bool ParameterTypeIs(
      GameParameter.ParameterTypes start,
      GameParameter.ParameterTypes end)
    {
      return new bool();
    }

    [Token(Token = "0x17000556")]
    private bool IsParameterType_Rune
    {
      [Token(Token = "0x6003F71"), Address(RVA = "0x1182800", Offset = "0x1181600", VA = "0x11182800")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000557")]
    private bool IsParameterType_Ranking
    {
      [Token(Token = "0x6003F72"), Address(RVA = "0x11827E0", Offset = "0x11815E0", VA = "0x111827E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000558")]
    private bool IsParameterType_CombatPower
    {
      [Token(Token = "0x6003F73"), Address(RVA = "0x11827C0", Offset = "0x11815C0", VA = "0x111827C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000559")]
    private bool IsParameterType_TruthEquipment
    {
      [Token(Token = "0x6003F74"), Address(RVA = "0x1182820", Offset = "0x1181620", VA = "0x11182820")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003F75")]
    [Address(RVA = "0x117B340", Offset = "0x117A140", VA = "0x1117B340")]
    private SupportData GetSupportData() => (SupportData) null;

    [Token(Token = "0x6003F76")]
    [Address(RVA = "0x117A140", Offset = "0x1178F40", VA = "0x1117A140")]
    private FriendData GetFriendData() => (FriendData) null;

    [Token(Token = "0x6003F77")]
    [Address(RVA = "0x1179D10", Offset = "0x1178B10", VA = "0x11179D10")]
    private AbilityParam GetAbilityParam() => (AbilityParam) null;

    [Token(Token = "0x6003F78")]
    [Address(RVA = "0x1179CD0", Offset = "0x1178AD0", VA = "0x11179CD0")]
    private AbilityData GetAbilityData() => (AbilityData) null;

    [Token(Token = "0x6003F79")]
    [Address(RVA = "0x1179DA0", Offset = "0x1178BA0", VA = "0x11179DA0")]
    private ArenaPlayer GetArenaPlayer() => (ArenaPlayer) null;

    [Token(Token = "0x6003F7A")]
    [Address(RVA = "0x1179E70", Offset = "0x1178C70", VA = "0x11179E70")]
    private ArtifactParam GetArtifactParam() => (ArtifactParam) null;

    [Token(Token = "0x6003F7B")]
    [Address(RVA = "0x1179E30", Offset = "0x1178C30", VA = "0x11179E30")]
    private ArtifactData GetArtifactData() => (ArtifactData) null;

    [Token(Token = "0x6003F7C")]
    [Address(RVA = "0x1180860", Offset = "0x117F660", VA = "0x11180860")]
    private void SetArtifactFrame(ArtifactParam param)
    {
    }

    [Token(Token = "0x6003F7D")]
    [Address(RVA = "0x117BC90", Offset = "0x117AA90", VA = "0x1117BC90")]
    private Unit GetUnit() => (Unit) null;

    [Token(Token = "0x6003F7E")]
    [Address(RVA = "0x117BC30", Offset = "0x117AA30", VA = "0x1117BC30")]
    private UnitParam GetUnitParam() => (UnitParam) null;

    [Token(Token = "0x6003F7F")]
    [Address(RVA = "0x117B560", Offset = "0x117A360", VA = "0x1117B560")]
    private UnitData GetUnitData() => (UnitData) null;

    [Token(Token = "0x6003F80")]
    [Address(RVA = "0x117AB50", Offset = "0x1179950", VA = "0x1117AB50")]
    private PhotonPlayerData.UnitDataElem GetMultiUnitDataElem(int index)
    {
      return (PhotonPlayerData.UnitDataElem) null;
    }

    [Token(Token = "0x6003F81")]
    [Address(RVA = "0x117BF60", Offset = "0x117AD60", VA = "0x1117BF60")]
    private PhotonPlayerData GetVersusPlayerParam(PhotonPlayerData[] players, int cnt)
    {
      return (PhotonPlayerData) null;
    }

    [Token(Token = "0x6003F82")]
    [Address(RVA = "0x117BDC0", Offset = "0x117ABC0", VA = "0x1117BDC0")]
    private PhotonPlayerData GetVersusPlayerParam() => (PhotonPlayerData) null;

    [Token(Token = "0x6003F83")]
    [Address(RVA = "0x117ADB0", Offset = "0x1179BB0", VA = "0x1117ADB0")]
    private PartyData GetPartyData() => (PartyData) null;

    [Token(Token = "0x6003F84")]
    [Address(RVA = "0x117A8F0", Offset = "0x11796F0", VA = "0x1117A8F0")]
    private SkillParam GetLeaderSkill(PartyData party) => (SkillParam) null;

    [Token(Token = "0x6003F85")]
    [Address(RVA = "0x117A370", Offset = "0x1179170", VA = "0x1117A370")]
    private ItemParam GetItemParam() => (ItemParam) null;

    [Token(Token = "0x6003F86")]
    [Address(RVA = "0x117A240", Offset = "0x1179040", VA = "0x1117A240")]
    private ItemData GetInventoryItemData() => (ItemData) null;

    [Token(Token = "0x6003F87")]
    [Address(RVA = "0x117AA50", Offset = "0x1179850", VA = "0x1117AA50")]
    private PlayerLevelUpInfo GetLevelUpInfo() => (PlayerLevelUpInfo) null;

    [Token(Token = "0x6003F88")]
    [Address(RVA = "0x117A2D0", Offset = "0x11790D0", VA = "0x1117A2D0")]
    private ItemParam GetInventoryItemParam() => (ItemParam) null;

    [Token(Token = "0x6003F89")]
    [Address(RVA = "0x117B2C0", Offset = "0x117A0C0", VA = "0x1117B2C0")]
    private SkillData GetSkillData() => (SkillData) null;

    [Token(Token = "0x6003F8A")]
    [Address(RVA = "0x117B300", Offset = "0x117A100", VA = "0x1117B300")]
    private SkillParam GetSkillParam() => (SkillParam) null;

    [Token(Token = "0x6003F8B")]
    [Address(RVA = "0x117A880", Offset = "0x1179680", VA = "0x1117A880")]
    private JobParam GetJobParam() => (JobParam) null;

    [Token(Token = "0x6003F8C")]
    [Address(RVA = "0x117BB90", Offset = "0x117A990", VA = "0x1117BB90")]
    private EquipData GetUnitEquipData() => (EquipData) null;

    [Token(Token = "0x6003F8D")]
    [Address(RVA = "0x117A080", Offset = "0x1178E80", VA = "0x1117A080")]
    private EquipData GetEquipData() => (EquipData) null;

    [Token(Token = "0x6003F8E")]
    [Address(RVA = "0x117AEA0", Offset = "0x1179CA0", VA = "0x1117AEA0")]
    private QuestParam GetQuestParamAuto() => (QuestParam) null;

    [Token(Token = "0x6003F8F")]
    [Address(RVA = "0x117B3C0", Offset = "0x117A1C0", VA = "0x1117B3C0")]
    private TowerRewardItem GetTowerRewardItem() => (TowerRewardItem) null;

    [Token(Token = "0x6003F90")]
    [Address(RVA = "0x117AFA0", Offset = "0x1179DA0", VA = "0x1117AFA0")]
    private QuestParam GetQuestParam() => (QuestParam) null;

    [Token(Token = "0x6003F91")]
    [Address(RVA = "0x117ADF0", Offset = "0x1179BF0", VA = "0x1117ADF0")]
    private PhotonPlayerData GetPlayerData() => (PhotonPlayerData) null;

    [Token(Token = "0x6003F92")]
    [Address(RVA = "0x1179C90", Offset = "0x1178A90", VA = "0x11179C90")]
    private MultiPlayAPIRoom GetAPIRoom() => (MultiPlayAPIRoom) null;

    [Token(Token = "0x6003F93")]
    [Address(RVA = "0x117B110", Offset = "0x1179F10", VA = "0x1117B110")]
    private PhotonRoomData GetRoomData() => (PhotonRoomData) null;

    [Token(Token = "0x6003F94")]
    [Address(RVA = "0x11802A0", Offset = "0x117F0A0", VA = "0x111802A0")]
    private bool LoadItemIcon(string iconName) => new bool();

    [Token(Token = "0x6003F95")]
    [Address(RVA = "0x1180360", Offset = "0x117F160", VA = "0x11180360")]
    private bool LoadItemIcon(ItemParam itemParam) => new bool();

    [Token(Token = "0x6003F96")]
    [Address(RVA = "0x1180CE0", Offset = "0x117FAE0", VA = "0x11180CE0")]
    private void SetItemFrame(ItemParam itemParam)
    {
    }

    [Token(Token = "0x6003F97")]
    [Address(RVA = "0x1180B10", Offset = "0x117F910", VA = "0x11180B10")]
    private void SetEquipItemFrame(ItemParam itemParam)
    {
    }

    [Token(Token = "0x6003F98")]
    [Address(RVA = "0x117AAD0", Offset = "0x11798D0", VA = "0x1117AAD0")]
    private MailData GetMailData() => (MailData) null;

    [Token(Token = "0x6003F99")]
    [Address(RVA = "0x117B1C0", Offset = "0x1179FC0", VA = "0x1117B1C0")]
    private SellItem GetSellItem() => (SellItem) null;

    [Token(Token = "0x6003F9A")]
    [Address(RVA = "0x117B180", Offset = "0x1179F80", VA = "0x1117B180")]
    private List<SellItem> GetSellItemList() => (List<SellItem>) null;

    [Token(Token = "0x6003F9B")]
    [Address(RVA = "0x117B200", Offset = "0x117A000", VA = "0x1117B200")]
    private ShopItem GetShopItem() => (ShopItem) null;

    [Token(Token = "0x6003F9C")]
    [Address(RVA = "0x117AA90", Offset = "0x1179890", VA = "0x1117AA90")]
    private LimitedShopItem GetLimitedShopItem() => (LimitedShopItem) null;

    [Token(Token = "0x6003F9D")]
    [Address(RVA = "0x117A100", Offset = "0x1178F00", VA = "0x1117A100")]
    private EventShopItem GetEventShopItem() => (EventShopItem) null;

    [Token(Token = "0x6003F9E")]
    [Address(RVA = "0x117A180", Offset = "0x1178F80", VA = "0x1117A180")]
    private GachaParam GetGachaParam() => (GachaParam) null;

    [Token(Token = "0x6003F9F")]
    [Address(RVA = "0x1180A50", Offset = "0x117F850", VA = "0x11180A50")]
    private void SetBuyPriceTypeIcon(ESaleType type)
    {
    }

    [Token(Token = "0x6003FA0")]
    [Address(RVA = "0x1180940", Offset = "0x117F740", VA = "0x11180940")]
    private void SetBuyPriceEventCoinTypeIcon(string cost_iname)
    {
    }

    [Token(Token = "0x6003FA1")]
    [Address(RVA = "0x11806C0", Offset = "0x117F4C0", VA = "0x111806C0")]
    private void SelectCoinDescription(string description)
    {
    }

    [Token(Token = "0x6003FA2")]
    [Address(RVA = "0x117B520", Offset = "0x117A320", VA = "0x1117B520")]
    private TrophyParam GetTrophyParam() => (TrophyParam) null;

    [Token(Token = "0x6003FA3")]
    [Address(RVA = "0x117B4E0", Offset = "0x117A2E0", VA = "0x1117B4E0")]
    private TrophyObjective GetTrophyObjective() => (TrophyObjective) null;

    [Token(Token = "0x6003FA4")]
    [Address(RVA = "0x117A000", Offset = "0x1178E00", VA = "0x1117A000")]
    private EnhanceEquipData GetEnhanceEquipData() => (EnhanceEquipData) null;

    [Token(Token = "0x6003FA5")]
    [Address(RVA = "0x117A040", Offset = "0x1178E40", VA = "0x1117A040")]
    private EnhanceMaterial GetEnhanceMaterial() => (EnhanceMaterial) null;

    [Token(Token = "0x6003FA6")]
    [Address(RVA = "0x117A0C0", Offset = "0x1178EC0", VA = "0x1117A0C0")]
    private EquipItemParameter GetEquipItemParameter() => (EquipItemParameter) null;

    [Token(Token = "0x6003FA7")]
    [Address(RVA = "0x117AC90", Offset = "0x1179A90", VA = "0x1117AC90")]
    private string GetParamTypeName(ParamTypes type, string tag = "") => (string) null;

    [Token(Token = "0x6003FA8")]
    [Address(RVA = "0x1179C30", Offset = "0x1178A30", VA = "0x11179C30")]
    private bool CheckUnlockInstanceType() => new bool();

    [Token(Token = "0x6003FA9")]
    [Address(RVA = "0x117B4A0", Offset = "0x117A2A0", VA = "0x1117B4A0")]
    private TrickParam GetTrickParam() => (TrickParam) null;

    [Token(Token = "0x6003FAA")]
    [Address(RVA = "0x117AC50", Offset = "0x1179A50", VA = "0x1117AC50")]
    private BattleCore.OrderData GetOrderData() => (BattleCore.OrderData) null;

    [Token(Token = "0x6003FAB")]
    [Address(RVA = "0x117AB10", Offset = "0x1179910", VA = "0x1117AB10")]
    private MapEffectParam GetMapEffectParam() => (MapEffectParam) null;

    [Token(Token = "0x6003FAC")]
    [Address(RVA = "0x117BFE0", Offset = "0x117ADE0", VA = "0x1117BFE0")]
    private WeatherParam GetWeatherParam() => (WeatherParam) null;

    [Token(Token = "0x6003FAD")]
    [Address(RVA = "0x11801E0", Offset = "0x117EFE0", VA = "0x111801E0")]
    private bool LoadArtifactIcon(ArtifactParam param) => new bool();

    [Token(Token = "0x6003FAE")]
    [Address(RVA = "0x117AE40", Offset = "0x1179C40", VA = "0x1117AE40")]
    private void GetQuestObjectiveCount(QuestParam questParam, out int compCount, out int maxCount)
    {
    }

    [Token(Token = "0x6003FAF")]
    [Address(RVA = "0x1179FB0", Offset = "0x1178DB0", VA = "0x11179FB0")]
    private BindRuneData GetBindRuneData() => (BindRuneData) null;

    [Token(Token = "0x6003FB0")]
    [Address(RVA = "0x1105E90", Offset = "0x1104C90", VA = "0x11105E90")]
    private void InternalUpdateValue()
    {
    }

    [Token(Token = "0x6003FB1")]
    [Address(RVA = "0x117C020", Offset = "0x117AE20", VA = "0x1117C020")]
    private void GuildRaidUpdateValue()
    {
    }

    [Token(Token = "0x6003FB2")]
    [Address(RVA = "0x1181BD0", Offset = "0x11809D0", VA = "0x11181BD0")]
    private void UpdateValue_Rune()
    {
    }

    [Token(Token = "0x6003FB3")]
    [Address(RVA = "0x1181770", Offset = "0x1180570", VA = "0x11181770")]
    private void UpdateValue_Ranking()
    {
    }

    [Token(Token = "0x6003FB4")]
    [Address(RVA = "0x1181620", Offset = "0x1180420", VA = "0x11181620")]
    private void UpdateValue_CombatPower()
    {
    }

    [Token(Token = "0x6003FB5")]
    [Address(RVA = "0x11822A0", Offset = "0x11810A0", VA = "0x111822A0")]
    private void UpdateValue_TruthEquipment()
    {
    }

    [Token(Token = "0x6003FB6")]
    [Address(RVA = "0x1182620", Offset = "0x1181420", VA = "0x11182620")]
    public static void UpdateValuesOfType(GameParameter.ParameterTypes type)
    {
    }

    [Token(Token = "0x6003FB7")]
    [Address(RVA = "0x1181390", Offset = "0x1180190", VA = "0x11181390")]
    public static void UpdateAll(GameObject root)
    {
    }

    [Token(Token = "0x6003FB8")]
    [Address(RVA = "0x11811F0", Offset = "0x117FFF0", VA = "0x111811F0")]
    private void SetUpdateInterval(float interval)
    {
    }

    [Token(Token = "0x6003FB9")]
    [Address(RVA = "0x11815C0", Offset = "0x11803C0", VA = "0x111815C0")]
    private IEnumerator UpdateTimer() => (IEnumerator) null;

    [Token(Token = "0x6003FBA")]
    [Address(RVA = "0x1180420", Offset = "0x117F220", VA = "0x11180420")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6003FBB")]
    [Address(RVA = "0x11812E0", Offset = "0x11800E0", VA = "0x111812E0")]
    public void ToggleChildren(bool visible)
    {
    }

    [Token(Token = "0x6003FBC")]
    [Address(RVA = "0x1181350", Offset = "0x1180150", VA = "0x11181350")]
    public void ToggleEmpty(bool visible)
    {
    }

    [Token(Token = "0x6003FBD")]
    [Address(RVA = "0x1180500", Offset = "0x117F300", VA = "0x11180500")]
    public void ResetToDefault()
    {
    }

    [Token(Token = "0x6003FBE")]
    [Address(RVA = "0x1181000", Offset = "0x117FE00", VA = "0x11181000")]
    private void SetTextValue(string value)
    {
    }

    [Token(Token = "0x6003FBF")]
    [Address(RVA = "0x1181160", Offset = "0x117FF60", VA = "0x11181160")]
    private void SetTextValue(int value)
    {
    }

    [Token(Token = "0x6003FC0")]
    [Address(RVA = "0x11810D0", Offset = "0x117FED0", VA = "0x111810D0")]
    private void SetTextValue(long value)
    {
    }

    [Token(Token = "0x6003FC1")]
    [Address(RVA = "0x1180F80", Offset = "0x117FD80", VA = "0x11180F80")]
    private void SetTextColor(Color color)
    {
    }

    [Token(Token = "0x6003FC2")]
    [Address(RVA = "0x1180F00", Offset = "0x117FD00", VA = "0x11180F00")]
    private void SetSyncColorOriginColor(Color color)
    {
    }

    [Token(Token = "0x6003FC3")]
    [Address(RVA = "0x1180E40", Offset = "0x117FC40", VA = "0x11180E40")]
    private void SetSliderValue(int value, int maxValue)
    {
    }

    [Token(Token = "0x6003FC4")]
    [Address(RVA = "0x1180D80", Offset = "0x117FB80", VA = "0x11180D80")]
    private void SetSliderValue(long value, long maxValue)
    {
    }

    [Token(Token = "0x6003FC5")]
    [Address(RVA = "0x1180C70", Offset = "0x117FA70", VA = "0x11180C70")]
    private void SetImageIndex(int index)
    {
    }

    [Token(Token = "0x6003FC6")]
    [Address(RVA = "0x11807F0", Offset = "0x117F5F0", VA = "0x111807F0")]
    private void SetAnimatorInt(string name, int value)
    {
    }

    [Token(Token = "0x6003FC7")]
    [Address(RVA = "0x1180780", Offset = "0x117F580", VA = "0x11180780")]
    private void SetAnimatorBool(string name, bool value)
    {
    }

    [Token(Token = "0x6003FC8")]
    [Address(RVA = "0x117A1C0", Offset = "0x1178FC0", VA = "0x1117A1C0")]
    private int GetImageLength() => new int();

    [Token(Token = "0x6003FC9")]
    [Address(RVA = "0x1180BF0", Offset = "0x117F9F0", VA = "0x11180BF0")]
    private void SetImageBySpriteSheet(string key)
    {
    }

    [Token(Token = "0x6003FCA")]
    [Address(RVA = "0x1179920", Offset = "0x1178720", VA = "0x11179920")]
    private void Awake()
    {
    }

    [Token(Token = "0x6003FCB")]
    [Address(RVA = "0x11812C0", Offset = "0x11800C0", VA = "0x111812C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6003FCC")]
    [Address(RVA = "0x1180490", Offset = "0x117F290", VA = "0x11180490")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6003FCD")]
    [Address(RVA = "0x1182510", Offset = "0x1181310", VA = "0x11182510", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x6003FCE")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    protected virtual void BatchUpdate()
    {
    }

    [Token(Token = "0x6003FCF")]
    [Address(RVA = "0x11798C0", Offset = "0x11786C0", VA = "0x111798C0")]
    public static int AbilityTypeDetailToImageIndex(
      EAbilitySlot type,
      EAbilityTypeDetail typeDetail)
    {
      return new int();
    }

    [Token(Token = "0x6003FD0")]
    [Address(RVA = "0x11827A0", Offset = "0x11815A0", VA = "0x111827A0")]
    public GameParameter()
    {
    }

    [Token(Token = "0x6003FD1")]
    [Address(RVA = "0x1182720", Offset = "0x1181520", VA = "0x11182720")]
    static GameParameter()
    {
    }

    [Token(Token = "0x2000F32")]
    public enum QuestInstanceTypes
    {
      [Token(Token = "0x4002F73")] Any,
      [Token(Token = "0x4002F74")] Playing,
      [Token(Token = "0x4002F75")] Selected,
    }

    [Token(Token = "0x2000F33")]
    public enum ArenaPlayerInstanceTypes
    {
      [Token(Token = "0x4002F77")] Any,
      [Token(Token = "0x4002F78")] Enemy,
    }

    [Token(Token = "0x2000F34")]
    public enum UnitInstanceTypes
    {
      [Token(Token = "0x4002F7A")] Any,
      [Token(Token = "0x4002F7B")] OBSOLETE_MainTarget,
      [Token(Token = "0x4002F7C")] OBSOLETE_SubTarget,
      [Token(Token = "0x4002F7D")] CurrentTurn,
      [Token(Token = "0x4002F7E")] ArenaPlayerUnit0,
      [Token(Token = "0x4002F7F")] ArenaPlayerUnit1,
      [Token(Token = "0x4002F80")] ArenaPlayerUnit2,
      [Token(Token = "0x4002F81")] EnemyArenaPlayerUnit0,
      [Token(Token = "0x4002F82")] EnemyArenaPlayerUnit1,
      [Token(Token = "0x4002F83")] EnemyArenaPlayerUnit2,
      [Token(Token = "0x4002F84")] PartyUnit0,
      [Token(Token = "0x4002F85")] PartyUnit1,
      [Token(Token = "0x4002F86")] PartyUnit2,
      [Token(Token = "0x4002F87")] VersusUnit,
      [Token(Token = "0x4002F88")] MultiUnit,
      [Token(Token = "0x4002F89")] MultiTowerUnit,
      [Token(Token = "0x4002F8A")] VersusCpuUnit0,
      [Token(Token = "0x4002F8B")] VersusCpuUnit1,
      [Token(Token = "0x4002F8C")] VersusCpuUnit2,
      [Token(Token = "0x4002F8D")] RankMatchUnit,
      [Token(Token = "0x4002F8E")] FriendPartyUnit,
      [Token(Token = "0x4002F8F")] VersusDraftPlayerUnit0,
      [Token(Token = "0x4002F90")] VersusDraftPlayerUnit1,
      [Token(Token = "0x4002F91")] VersusDraftPlayerUnit2,
      [Token(Token = "0x4002F92")] VersusDraftPlayerUnit3,
      [Token(Token = "0x4002F93")] VersusDraftPlayerUnit4,
      [Token(Token = "0x4002F94")] VersusDraftPlayerUnit5,
      [Token(Token = "0x4002F95")] VersusDraftEnemyUnit0,
      [Token(Token = "0x4002F96")] VersusDraftEnemyUnit1,
      [Token(Token = "0x4002F97")] VersusDraftEnemyUnit2,
      [Token(Token = "0x4002F98")] VersusDraftEnemyUnit3,
      [Token(Token = "0x4002F99")] VersusDraftEnemyUnit4,
      [Token(Token = "0x4002F9A")] VersusDraftEnemyUnit5,
    }

    [Token(Token = "0x2000F35")]
    public enum PartyAttackTypes
    {
      [Token(Token = "0x4002F9C")] Normal,
      [Token(Token = "0x4002F9D")] Quest,
    }

    [Token(Token = "0x2000F36")]
    public enum TargetInstanceTypes
    {
      [Token(Token = "0x4002F9F")] Main,
      [Token(Token = "0x4002FA0")] Sub,
    }

    [Token(Token = "0x2000F37")]
    public enum ItemInstanceTypes
    {
      [Token(Token = "0x4002FA2")] Any,
      [Token(Token = "0x4002FA3")] Inventory,
      [Token(Token = "0x4002FA4")] QuestReward,
      [Token(Token = "0x4002FA5")] Equipment,
      [Token(Token = "0x4002FA6")] EnhanceMaterial,
      [Token(Token = "0x4002FA7")] EnhanceEquipData,
      [Token(Token = "0x4002FA8")] SellItem,
      [Token(Token = "0x4002FA9")] ConsumeItem,
    }

    [Token(Token = "0x2000F38")]
    public enum ItemViewTypes
    {
      [Token(Token = "0x4002FAB")] HideLimitedIcon,
      [Token(Token = "0x4002FAC")] DisplayLimitedIcon,
    }

    [Token(Token = "0x2000F39")]
    public enum ArtifactInstanceTypes
    {
      [Token(Token = "0x4002FAE")] Any,
      [Token(Token = "0x4002FAF")] QuestReward,
      [Token(Token = "0x4002FB0")] Trophy,
    }

    [Token(Token = "0x2000F3A")]
    public enum TrophyBadgeInstanceTypes
    {
      [Token(Token = "0x4002FB2")] Any,
      [Token(Token = "0x4002FB3")] Normal,
      [Token(Token = "0x4002FB4")] Daily,
      [Token(Token = "0x4002FB5")] NormalStory,
      [Token(Token = "0x4002FB6")] NormalEvent,
      [Token(Token = "0x4002FB7")] NormalTraining,
      [Token(Token = "0x4002FB8")] NormalOther,
    }

    [Token(Token = "0x2000F3B")]
    public enum TrophyConditionInstances
    {
      [Token(Token = "0x4002FBA")] List,
      [Token(Token = "0x4002FBB")] Index,
    }

    [Token(Token = "0x2000F3C")]
    public enum VersusPlayerInstanceType
    {
      [Token(Token = "0x4002FBD")] Player,
      [Token(Token = "0x4002FBE")] Enemy,
    }

    [Token(Token = "0x2000F3D")]
    public enum RankMatchPlayer
    {
      [Token(Token = "0x4002FC0")] Current,
      [Token(Token = "0x4002FC1")] Before,
    }

    [Token(Token = "0x2000F3E")]
    public enum VersusDraftSlot
    {
      [Token(Token = "0x4002FC3")] PlayerLeader,
      [Token(Token = "0x4002FC4")] PlayerSlot2,
      [Token(Token = "0x4002FC5")] PlayerSlot3,
      [Token(Token = "0x4002FC6")] PlayerSlot4,
      [Token(Token = "0x4002FC7")] PlayerSlot5,
      [Token(Token = "0x4002FC8")] EnemyLeader,
      [Token(Token = "0x4002FC9")] EnemySlot2,
      [Token(Token = "0x4002FCA")] EnemySlot3,
      [Token(Token = "0x4002FCB")] EnemySlot4,
      [Token(Token = "0x4002FCC")] EnemySlot5,
    }

    [Token(Token = "0x2000F3F")]
    public enum LimitItemInstanceType
    {
      [Token(Token = "0x4002FCE")] Any,
      [Token(Token = "0x4002FCF")] GachaDiscount,
      [Token(Token = "0x4002FD0")] ItemDetail,
    }

    [Token(Token = "0x2000F40")]
    public enum RaidRescueStatusType
    {
      [Token(Token = "0x4002FD2")] Yet,
      [Token(Token = "0x4002FD3")] Done,
    }

    [Token(Token = "0x2000F41")]
    private enum eEntryCondition
    {
      [Token(Token = "0x4002FD5")] EntryCondition,
      [Token(Token = "0x4002FD6")] SameUnit,
      [Token(Token = "0x4002FD7")] Used_WorldRaid,
      [Token(Token = "0x4002FD8")] Max,
    }

    [Token(Token = "0x2000F42")]
    private enum GvGStatus
    {
      [Token(Token = "0x4002FDA")] GVG_DECLARE,
      [Token(Token = "0x4002FDB")] GVG_BATTLE,
      [Token(Token = "0x4002FDC")] GVG_DECLARE_COOLTIME,
      [Token(Token = "0x4002FDD")] GVG_AGGREGATION,
      [Token(Token = "0x4002FDE")] GVG_FINISH,
      [Token(Token = "0x4002FDF")] GVG_BATTLE_COOLTIME,
    }

    [Token(Token = "0x2000F43")]
    public enum ParameterTypes
    {
      [Token(Token = "0x4002FE1"), GameParameter.ParameterDesc("プレイヤーの名前")] GLOBAL_PLAYER_NAME = 0,
      [Token(Token = "0x4002FE2"), GameParameter.ParameterDesc("プレイヤーのレベル")] GLOBAL_PLAYER_LEVEL = 1,
      [Token(Token = "0x4002FE3"), GameParameter.ParameterDesc("プレイヤーの現在のスタミナ")] GLOBAL_PLAYER_STAMINA = 2,
      [Token(Token = "0x4002FE4"), GameParameter.ParameterDesc("プレイヤーの最大スタミナ")] GLOBAL_PLAYER_STAMINAMAX = 3,
      [Token(Token = "0x4002FE5"), GameParameter.ParameterDesc("プレイヤーの経験値")] GLOBAL_PLAYER_EXP = 4,
      [Token(Token = "0x4002FE6"), GameParameter.ParameterDesc("プレイヤーが次のレベルまでに必要な経験値")] GLOBAL_PLAYER_EXPNEXT = 5,
      [Token(Token = "0x4002FE7"), GameParameter.ParameterDesc("プレイヤーの所持ゴールド")] GLOBAL_PLAYER_GOLD = 6,
      [Token(Token = "0x4002FE8"), GameParameter.ParameterDesc("プレイヤーの所持コイン")] GLOBAL_PLAYER_COIN = 7,
      [Token(Token = "0x4002FE9"), GameParameter.ParameterDesc("プレイヤーのスタミナが次に回復するまでの時間")] GLOBAL_PLAYER_STAMINATIME = 8,
      [Token(Token = "0x4002FEA"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes)), GameParameter.ParameterDesc("クエスト名")] QUEST_NAME = 9,
      [Token(Token = "0x4002FEB"), GameParameter.ParameterDesc("クエストに必要なスタミナ"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes))] QUEST_STAMINA = 10, // 0x0000000A
      [Token(Token = "0x4002FEC"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes)), GameParameter.EnumParameterDesc("クエストのクリア状態にあわせてAnimatorのstateという名前のInt値、ImageArrayのインデックスを切り替えます。", typeof (QuestStates))] QUEST_STATE = 11, // 0x0000000B
      [Token(Token = "0x4002FED"), GameParameter.ParameterDesc("クエスト勝利条件"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes))] QUEST_OBJECTIVE = 12, // 0x0000000C
      [Token(Token = "0x4002FEE"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes)), GameParameter.ParameterDesc("クエストボーナス条件。インデックスでボーナス条件の番号を指定してください。"), GameParameter.UsesIndex] QUEST_BONUSOBJECTIVE = 13, // 0x0000000D
      [Token(Token = "0x4002FEF"), GameParameter.UsesIndex, GameParameter.ViewTypes(typeof (GameParameter.ItemViewTypes)), GameParameter.InstanceTypes(typeof (GameParameter.ItemInstanceTypes)), GameParameter.ParameterDesc("アイテムアイコン")] ITEM_ICON = 14, // 0x0000000E
      [Token(Token = "0x4002FF0"), GameParameter.ParameterDesc("クエストの説明"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes))] QUEST_DESCRIPTION = 15, // 0x0000000F
      [Token(Token = "0x4002FF1"), GameParameter.ParameterDesc("フレンドの名前")] SUPPORTER_NAME = 16, // 0x00000010
      [Token(Token = "0x4002FF2"), GameParameter.ParameterDesc("フレンドのレベル")] SUPPORTER_LEVEL = 17, // 0x00000011
      [Token(Token = "0x4002FF3"), GameParameter.ParameterDesc("フレンドのユニットレベル")] SUPPORTER_UNITLEVEL = 18, // 0x00000012
      [Token(Token = "0x4002FF4"), GameParameter.ParameterDesc("フレンドのリーダースキル名")] SUPPORTER_LEADERSKILLNAME = 19, // 0x00000013
      [Token(Token = "0x4002FF5"), GameParameter.ParameterDesc("フレンドの攻撃力")] SUPPORTER_ATK = 20, // 0x00000014
      [Token(Token = "0x4002FF6"), GameParameter.ParameterDesc("フレンドのHP")] SUPPORTER_HP = 21, // 0x00000015
      [Token(Token = "0x4002FF7"), GameParameter.ParameterDesc("フレンドの魔法攻撃力")] SUPPORTER_MAGIC = 22, // 0x00000016
      [Token(Token = "0x4002FF8"), GameParameter.EnumParameterDesc("フレンドのレアリティにあわせてAnimatorのrareという名前のInt値を切り替えます。", typeof (ERarity))] SUPPORTER_RARITY = 23, // 0x00000017
      [Token(Token = "0x4002FF9"), GameParameter.EnumParameterDesc("フレンドの属性にあわせてAnimatorのelementという名前のInt値を切り替えます。", typeof (EElement))] SUPPORTER_ELEMENT = 24, // 0x00000018
      [Token(Token = "0x4002FFA"), GameParameter.ParameterDesc("フレンドのアイコン")] SUPPORTER_ICON = 25, // 0x00000019
      [Token(Token = "0x4002FFB"), GameParameter.ParameterDesc("フレンドのリーダースキルの説明")] SUPPORTER_LEADERSKILLDESC = 26, // 0x0000001A
      [Token(Token = "0x4002FFC"), GameParameter.ParameterDesc("クエストの副題"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes))] QUEST_SUBTITLE = 27, // 0x0000001B
      [Token(Token = "0x4002FFD"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットのレベル")] UNIT_LEVEL = 28, // 0x0000001C
      [Token(Token = "0x4002FFE"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットのHP")] UNIT_HP = 29, // 0x0000001D
      [Token(Token = "0x4002FFF"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの最大HP")] UNIT_HPMAX = 30, // 0x0000001E
      [Token(Token = "0x4003000"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの攻撃力")] UNIT_ATK = 31, // 0x0000001F
      [Token(Token = "0x4003001"), GameParameter.ParameterDesc("ユニットの魔力"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_MAG = 32, // 0x00000020
      [Token(Token = "0x4003002"), GameParameter.ParameterDesc("ユニットのアイコン"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_ICON = 33, // 0x00000021
      [Token(Token = "0x4003003"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの名前")] UNIT_NAME = 34, // 0x00000022
      [Token(Token = "0x4003004"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.EnumParameterDesc("ユニットのレアリティに応じてAnimatorにrareというint値を設定します。ImageArrayの場合レアリティに応じた番号のイメージを使用します。StarGaugeの場合現在のレアリティと最大のレアリティがそれぞれ現在値と最大値になります。", typeof (ERarity))] UNIT_RARITY = 35, // 0x00000023
      [Token(Token = "0x4003005"), GameParameter.ParameterDesc("パーティのリーダースキルの名前")] PARTY_LEADERSKILLNAME = 36, // 0x00000024
      [Token(Token = "0x4003006"), GameParameter.ParameterDesc("パーティのリーダースキルの説明")] PARTY_LEADERSKILLDESC = 37, // 0x00000025
      [Token(Token = "0x4003007"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの防御力")] UNIT_DEF = 38, // 0x00000026
      [Token(Token = "0x4003008"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの魔法防御力")] UNIT_MND = 39, // 0x00000027
      [Token(Token = "0x4003009"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの素早さ")] UNIT_SPEED = 40, // 0x00000028
      [Token(Token = "0x400300A"), GameParameter.ParameterDesc("ユニットの運"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_LUCK = 41, // 0x00000029
      [Token(Token = "0x400300B"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットジョブ名")] UNIT_JOBNAME = 42, // 0x0000002A
      [Token(Token = "0x400300C"), GameParameter.ParameterDesc("ユニットジョブランク"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_JOBRANK = 43, // 0x0000002B
      [Token(Token = "0x400300D"), GameParameter.EnumParameterDesc("ユニット属性にあわせてAnimatorのelementという名前のInt値、もしくはImageArrayを切り替えます。", typeof (EElement)), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_ELEMENT = 44, // 0x0000002C
      [Token(Token = "0x400300E"), GameParameter.ParameterDesc("パーティの総攻撃力"), GameParameter.InstanceTypes(typeof (GameParameter.PartyAttackTypes))] PARTY_TOTALATK = 45, // 0x0000002D
      [Token(Token = "0x400300F"), GameParameter.ParameterDesc("インベントリーにセットされたアイテムのアイコン\n*スロット番号をIndexで指定"), GameParameter.ViewTypes(typeof (GameParameter.ItemViewTypes)), GameParameter.UsesIndex] INVENTORY_ITEMICON = 46, // 0x0000002E
      [Token(Token = "0x4003010"), GameParameter.ParameterDesc("インベントリーにセットされたアイテムの名前*スロット番号をIndexで指定"), GameParameter.UsesIndex] INVENTORY_ITEMNAME = 47, // 0x0000002F
      [Token(Token = "0x4003011"), GameParameter.ParameterDesc("アイテムの名前"), GameParameter.InstanceTypes(typeof (GameParameter.ItemInstanceTypes)), GameParameter.UsesIndex] ITEM_NAME = 48, // 0x00000030
      [Token(Token = "0x4003012"), GameParameter.ParameterDesc("アイテムの説明"), GameParameter.InstanceTypes(typeof (GameParameter.ItemInstanceTypes)), GameParameter.UsesIndex] ITEM_DESC = 49, // 0x00000031
      [Token(Token = "0x4003013"), GameParameter.InstanceTypes(typeof (GameParameter.ItemInstanceTypes)), GameParameter.UsesIndex, GameParameter.ParameterDesc("アイテムの売却価格")] ITEM_SELLPRICE = 50, // 0x00000032
      [Token(Token = "0x4003014"), GameParameter.UsesIndex, GameParameter.InstanceTypes(typeof (GameParameter.ItemInstanceTypes)), GameParameter.ParameterDesc("アイテムの購入価格")] ITEM_BUYPRICE = 51, // 0x00000033
      [Token(Token = "0x4003015"), GameParameter.InstanceTypes(typeof (GameParameter.ItemInstanceTypes)), GameParameter.ParameterDesc("アイテムの所持個数"), GameParameter.UsesIndex] ITEM_AMOUNT = 52, // 0x00000034
      [Token(Token = "0x4003016"), GameParameter.ParameterDesc("インベントリーにセットされたアイテムの所持数*スロット番号をIndexで指定"), GameParameter.UsesIndex] INVENTORY_ITEMAMOUNT = 53, // 0x00000035
      [Token(Token = "0x4003017"), GameParameter.ParameterDesc("所持ユニット数")] PLAYER_NUMUNITS = 54, // 0x00000036
      [Token(Token = "0x4003018"), GameParameter.ParameterDesc("所持可能の最大ユニット数")] PLAYER_MAXUNITS = 55, // 0x00000037
      [Token(Token = "0x4003019"), GameParameter.ParameterDesc("選択しているグリッドの高さ")] GRID_HEIGHT = 56, // 0x00000038
      [Token(Token = "0x400301A"), GameParameter.ParameterDesc("スキルの名前")] SKILL_NAME = 57, // 0x00000039
      [Token(Token = "0x400301B"), GameParameter.ParameterDesc("スキルのアイコン")] SKILL_ICON = 58, // 0x0000003A
      [Token(Token = "0x400301C"), GameParameter.ParameterDesc("スキルの説明")] SKILL_DESCRIPTION = 59, // 0x0000003B
      [Token(Token = "0x400301D"), GameParameter.ParameterDesc("スキルの消費ジュエル")] SKILL_MP = 60, // 0x0000003C
      [Token(Token = "0x400301E"), GameParameter.ParameterDesc("クエストで入手したゴールド")] BATTLE_GOLD = 61, // 0x0000003D
      [Token(Token = "0x400301F"), GameParameter.ParameterDesc("クエストで入手した宝箱の個数")] BATTLE_TREASURE = 62, // 0x0000003E
      [Token(Token = "0x4003020"), GameParameter.ParameterDesc("ユニットのMP"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_MP = 63, // 0x0000003F
      [Token(Token = "0x4003021"), GameParameter.ParameterDesc("ユニットの最大MP"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_MPMAX = 64, // 0x00000040
      [Token(Token = "0x4003022"), GameParameter.ParameterDesc("ターゲットの出力ポイント"), GameParameter.InstanceTypes(typeof (GameParameter.TargetInstanceTypes))] TARGET_OUTPUTPOINT = 65, // 0x00000041
      [Token(Token = "0x4003023"), GameParameter.ParameterDesc("ターゲットのクリティカル率"), GameParameter.InstanceTypes(typeof (GameParameter.TargetInstanceTypes))] TARGET_CRITICALRATE = 66, // 0x00000042
      [Token(Token = "0x4003024"), GameParameter.InstanceTypes(typeof (GameParameter.TargetInstanceTypes)), GameParameter.EnumParameterDesc("ターゲットの行動の種類にあわせてAnimatorにstate(Int)を設定する。", typeof (SceneBattle.TargetActionTypes))] TARGET_ACTIONTYPE = 67, // 0x00000043
      [Token(Token = "0x4003025"), GameParameter.ParameterDesc("アビリティのアイコン")] ABILITY_ICON = 68, // 0x00000044
      [Token(Token = "0x4003026"), GameParameter.ParameterDesc("アビリティの名前")] ABILITY_NAME = 69, // 0x00000045
      [Token(Token = "0x4003027"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes)), GameParameter.ParameterDesc("クエストで入手可能な欠片のアイコン")] QUEST_KAKERA_ICON = 70, // 0x00000046
      [Token(Token = "0x4003028"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの経験値")] UNIT_EXP = 71, // 0x00000047
      [Token(Token = "0x4003029"), GameParameter.ParameterDesc("ユニットのレベルアップに必要な経験値の合計"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_EXPMAX = 72, // 0x00000048
      [Token(Token = "0x400302A"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットのレベルアップに必要な経験値の残り")] UNIT_EXPTOGO = 73, // 0x00000049
      [Token(Token = "0x400302B"), GameParameter.ParameterDesc("ユニットの覚醒に必要な欠片の所持数"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_KAKERA_NUM = 74, // 0x0000004A
      [Token(Token = "0x400302C"), GameParameter.ParameterDesc("ユニットの覚醒に必要な欠片の数"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_KAKERA_MAX = 75, // 0x0000004B
      [Token(Token = "0x400302D"), GameParameter.ParameterDesc("装備品の経験値 (未実装)")] EQUIPMENT_EXP = 76, // 0x0000004C
      [Token(Token = "0x400302E"), GameParameter.ParameterDesc("装備品の強化に必要な経験値 (未実装)")] EQUIPMENT_EXPMAX = 77, // 0x0000004D
      [Token(Token = "0x400302F"), GameParameter.ParameterDesc("装備品のランク。Animatorであればrankというint値にランクを設定する。ImageArrayであればランクに対応したイメージを使用する。")] EQUIPMENT_RANK = 78, // 0x0000004E
      [Token(Token = "0x4003030"), GameParameter.ParameterDesc("アビリティのレベル")] ABILITY_RANK = 79, // 0x0000004F
      [Token(Token = "0x4003031"), GameParameter.ParameterDesc("アビリティの経験値")] OBSOLETE_ABILITY = 80, // 0x00000050
      [Token(Token = "0x4003032"), GameParameter.ParameterDesc("アビリティの最大経験値")] ABILITY_NEXTGOLD = 81, // 0x00000051
      [Token(Token = "0x4003033"), GameParameter.UsesIndex, GameParameter.EnumParameterDesc("アビリティの種類にあわせて、Animatorのtype、ImageArrayを切り替えます。", typeof (EAbilitySlot))] ABILITY_SLOT = 82, // 0x00000052
      [Token(Token = "0x4003034"), GameParameter.ParameterDesc("ユニットのIndexで指定したジョブのアイコン"), GameParameter.UsesIndex, GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_JOB_JOBICON = 83, // 0x00000053
      [Token(Token = "0x4003035"), GameParameter.ParameterDesc("ユニットのIndexで指定したジョブのランク"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.UsesIndex] UNIT_JOB_RANK = 84, // 0x00000054
      [Token(Token = "0x4003036"), GameParameter.ParameterDesc("ユニットのIndexで指定したジョブの名前"), GameParameter.UsesIndex, GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_JOB_NAME = 85, // 0x00000055
      [Token(Token = "0x4003037"), GameParameter.ParameterDesc("ユニットのIndexで指定したジョブの最大ランク"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.UsesIndex] UNIT_JOB_RANKMAX = 86, // 0x00000056
      [Token(Token = "0x4003038"), GameParameter.ParameterDesc("装備アイテムのHP。空のゲームオブジェクトの場合は値が0の時自身を非表示にします。"), GameParameter.AlwaysUpdate] EQUIPMENT_HP = 87, // 0x00000057
      [Token(Token = "0x4003039"), GameParameter.ParameterDesc("装備アイテムのAP。空のゲームオブジェクトの場合は値が0の時自身を非表示にします。"), GameParameter.AlwaysUpdate] EQUIPMENT_AP = 88, // 0x00000058
      [Token(Token = "0x400303A"), GameParameter.ParameterDesc("装備アイテムの初期AP。空のゲームオブジェクトの場合は値が0の時自身を非表示にします。"), GameParameter.AlwaysUpdate] EQUIPMENT_IAP = 89, // 0x00000059
      [Token(Token = "0x400303B"), GameParameter.ParameterDesc("装備アイテムの攻撃力。空のゲームオブジェクトの場合は値が0の時自身を非表示にします。"), GameParameter.AlwaysUpdate] EQUIPMENT_ATK = 90, // 0x0000005A
      [Token(Token = "0x400303C"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("装備アイテムの防御力。空のゲームオブジェクトの場合は値が0の時自身を非表示にします。")] EQUIPMENT_DEF = 91, // 0x0000005B
      [Token(Token = "0x400303D"), GameParameter.ParameterDesc("装備アイテムの魔法攻撃力。空のゲームオブジェクトの場合は値が0の時自身を非表示にします。"), GameParameter.AlwaysUpdate] EQUIPMENT_MAG = 92, // 0x0000005C
      [Token(Token = "0x400303E"), GameParameter.ParameterDesc("装備アイテムの魔法防御力。空のゲームオブジェクトの場合は値が0の時自身を非表示にします。"), GameParameter.AlwaysUpdate] EQUIPMENT_MND = 93, // 0x0000005D
      [Token(Token = "0x400303F"), GameParameter.ParameterDesc("装備アイテムの回復力。空のゲームオブジェクトの場合は値が0の時自身を非表示にします。"), GameParameter.AlwaysUpdate] EQUIPMENT_REC = 94, // 0x0000005E
      [Token(Token = "0x4003040"), GameParameter.ParameterDesc("装備アイテムの速度。空のゲームオブジェクトの場合は値が0の時自身を非表示にします。"), GameParameter.AlwaysUpdate] EQUIPMENT_SPD = 95, // 0x0000005F
      [Token(Token = "0x4003041"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("装備アイテムのクリティカル。空のゲームオブジェクトの場合は値が0の時自身を非表示にします。")] EQUIPMENT_CRI = 96, // 0x00000060
      [Token(Token = "0x4003042"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("装備アイテムの運。空のゲームオブジェクトの場合は値が0の時自身を非表示にします。")] EQUIPMENT_LUK = 97, // 0x00000061
      [Token(Token = "0x4003043"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("装備アイテムの移動量。空のゲームオブジェクトの場合は値が0の時自身を非表示にします。")] EQUIPMENT_MOV = 98, // 0x00000062
      [Token(Token = "0x4003044"), GameParameter.ParameterDesc("装備アイテムの移動高低差。空のゲームオブジェクトの場合は値が0の時自身を非表示にします。"), GameParameter.AlwaysUpdate] EQUIPMENT_JMP = 99, // 0x00000063
      [Token(Token = "0x4003045"), GameParameter.ParameterDesc("装備アイテムの射程。空のゲームオブジェクトの場合は値が0の時自身を非表示にします。"), GameParameter.AlwaysUpdate] EQUIPMENT_RANGE = 100, // 0x00000064
      [Token(Token = "0x4003046"), GameParameter.ParameterDesc("装備アイテムの範囲。空のゲームオブジェクトの場合は値が0の時自身を非表示にします。"), GameParameter.AlwaysUpdate] EQUIPMENT_SCOPE = 101, // 0x00000065
      [Token(Token = "0x4003047"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("装備アイテムの影響可能な高低差範囲。値が0の時、子供を非表示にし、LayoutElementを無効にします。")] EQUIPMENT_EFFECTHEIGHT = 102, // 0x00000066
      [Token(Token = "0x4003048"), GameParameter.ParameterDesc("装備アイテムの名前")] EQUIPMENT_NAME = 103, // 0x00000067
      [Token(Token = "0x4003049"), GameParameter.ParameterDesc("装備アイテムのアイコン")] EQUIPMENT_ICON = 104, // 0x00000068
      [Token(Token = "0x400304A"), GameParameter.ParameterDesc("アビリティ強化に使用できるポイントの残り")] OBSOLETE_GLOBAL_PLAYER_ABILITYPOINT_NUM = 105, // 0x00000069
      [Token(Token = "0x400304B"), GameParameter.ParameterDesc("アビリティを強化できる回数")] OBSOLETE_GLOBAL_PLAYER_ABILITYPOINT_RANKUPCOUNT = 106, // 0x0000006A
      [Token(Token = "0x400304C"), GameParameter.ParameterDesc("アビリティを強化できる回数の最大値")] OBSOLETE_GLOBAL_PLAYER_ABILITYPOINT_RANKUPCOUNTMAX = 107, // 0x0000006B
      [Token(Token = "0x400304D"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("アビリティを強化できる回数のクールダウン時間。\nクールダウン時間が無い場合は子供を非表示にします。")] OBSOLETE_GLOBAL_PLAYER_ABILITYPOINT_COOLDOWNTIME = 108, // 0x0000006C
      [Token(Token = "0x400304E"), GameParameter.ParameterDesc("装備アイテムの所持数")] EQUIPMENT_AMOUNT = 109, // 0x0000006D
      [Token(Token = "0x400304F"), GameParameter.ParameterDesc("装備アイテムを装備するために必要なレベル")] EQUIPMENT_REQLV = 110, // 0x0000006E
      [Token(Token = "0x4003050"), GameParameter.ParameterDesc("進化素材の所持個数。スライダー対応")] JOBEVOITEM_AMOUNT = 111, // 0x0000006F
      [Token(Token = "0x4003051"), GameParameter.ParameterDesc("進化素材の必要個数")] JOBEVOITEM_REQAMOUNT = 112, // 0x00000070
      [Token(Token = "0x4003052"), GameParameter.ParameterDesc("進化素材のアイコン")] JOBEVOITEM_ICON = 113, // 0x00000071
      [Token(Token = "0x4003053"), GameParameter.ParameterDesc("進化素材の名前")] JOBEVOITEM_NAME = 114, // 0x00000072
      [Token(Token = "0x4003054"), GameParameter.ParameterDesc("ユニットの現在のジョブを進化させるのに必要なゴールド")] UNIT_EVOCOST = 115, // 0x00000073
      [Token(Token = "0x4003055"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットのクリティカル値")] UNIT_CRIT = 116, // 0x00000074
      [Token(Token = "0x4003056"), GameParameter.ParameterDesc("ユニットの回復力"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_REGEN = 117, // 0x00000075
      [Token(Token = "0x4003057"), GameParameter.ParameterDesc("ユニットが持つリーダースキルの名前"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_LEADERSKILLNAME = 118, // 0x00000076
      [Token(Token = "0x4003058"), GameParameter.ParameterDesc("ユニットが持つリーダースキルの説明"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_LEADERSKILLDESC = 119, // 0x00000077
      [Token(Token = "0x4003059"), GameParameter.ParameterDesc("アイテムの効果値")] ITEM_VALUE = 120, // 0x00000078
      [Token(Token = "0x400305A"), GameParameter.ParameterDesc("ユニットのレベルの最大値")] UNIT_LEVELMAX = 121, // 0x00000079
      [Token(Token = "0x400305B"), GameParameter.ParameterDesc("ユニットのIndexで指定したジョブの解放状態にあわせてAnimatorにBoolパラメーターunlockedを設定します。解放済みであればunlockedがオンになります。"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.UsesIndex] UNIT_JOB_UNLOCKSTATE = 122, // 0x0000007A
      [Token(Token = "0x400305C"), GameParameter.ParameterDesc("ユニットの現在のジョブのランク"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_JOBRANKMAX = 123, // 0x0000007B
      [Token(Token = "0x400305D"), GameParameter.ParameterDesc("アビリティの解放条件")] ABILITY_UNLOCKINFO = 124, // 0x0000007C
      [Token(Token = "0x400305E"), GameParameter.ParameterDesc("アビリティの説明")] ABILITY_DESC = 125, // 0x0000007D
      [Token(Token = "0x400305F"), GameParameter.UsesIndex, GameParameter.InstanceTypes(typeof (GameParameter.ItemInstanceTypes)), GameParameter.ParameterDesc("アイテムの種類にあわせたフレームをImageに設定します。フレームの設定はGameSettings.ItemIconsを参照します。")] ITEM_FRAME = 126, // 0x0000007E
      [Token(Token = "0x4003060"), GameParameter.UsesIndex, GameParameter.ParameterDesc("インベントリーにセットされたアイテムのフレーム。Item/Frameと同じです。")] INVENTORY_FRAME = 127, // 0x0000007F
      [Token(Token = "0x4003061"), GameParameter.ParameterDesc("アイテム作成素材の所持個数")] RECIPEITEM_AMOUNT = 128, // 0x00000080
      [Token(Token = "0x4003062"), GameParameter.ParameterDesc("アイテム作成素材の必要個数")] RECIPEITEM_REQAMOUNT = 129, // 0x00000081
      [Token(Token = "0x4003063"), GameParameter.ParameterDesc("アイテム作成素材のアイコン")] RECIPEITEM_ICON = 130, // 0x00000082
      [Token(Token = "0x4003064"), GameParameter.ParameterDesc("アイテム作成素材の名前")] RECIPEITEM_NAME = 131, // 0x00000083
      [Token(Token = "0x4003065"), GameParameter.ParameterDesc("アイテム作成コスト")] RECIPEITEM_CREATE_COST = 132, // 0x00000084
      [Token(Token = "0x4003066"), GameParameter.ParameterDesc("作成アイテム名")] RECIPEITEM_CREATE_ITEM_NAME = 133, // 0x00000085
      [Token(Token = "0x4003067"), GameParameter.ParameterDesc("アイテム作成素材のフレーム")] RECIPEITEM_FRAME = 134, // 0x00000086
      [Token(Token = "0x4003068"), GameParameter.ParameterDesc("ユニットのキャライメージ (中サイズ) GameSettings.Unit_PortraitMedium で命名規則を決めれます。"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_PORTRAIT_MEDIUM = 135, // 0x00000087
      [Token(Token = "0x4003069"), GameParameter.ParameterDesc("クエストで入手した補正値等も含めたゴールドの合計")] QUESTRESULT_GOLD = 136, // 0x00000088
      [Token(Token = "0x400306A"), GameParameter.ParameterDesc("クエストでプレイヤーが得た経験値")] QUESTRESULT_PLAYEREXP = 137, // 0x00000089
      [Token(Token = "0x400306B"), GameParameter.ParameterDesc("クエストでパーティが得た経験値")] QUESTRESULT_PARTYEXP = 138, // 0x0000008A
      [Token(Token = "0x400306C"), GameParameter.ParameterDesc("クエストの評価結果にあわせてAnimatorのrate(int)、ImageArrayを切り替えます。※使用してない")] QUESTRESULT_RATE = 139, // 0x0000008B
      [Token(Token = "0x400306D"), GameParameter.ParameterDesc("プレイヤーのレベルアップ前のレベル")] PLAYERLEVELUP_LEVEL = 140, // 0x0000008C
      [Token(Token = "0x400306E"), GameParameter.ParameterDesc("プレイヤーのレベルアップ後のレベル")] PLAYERLEVELUP_LEVELNEXT = 141, // 0x0000008D
      [Token(Token = "0x400306F"), GameParameter.ParameterDesc("プレイヤーのレベルアップ後のスタミナ")] PLAYERLEVELUP_STAMINA = 142, // 0x0000008E
      [Token(Token = "0x4003070"), GameParameter.ParameterDesc("プレイヤーのレベルアップ前の最大スタミナ")] PLAYERLEVELUP_STAMINAMAX = 143, // 0x0000008F
      [Token(Token = "0x4003071"), GameParameter.ParameterDesc("プレイヤーのレベルアップ後の最大スタミナ")] PLAYERLEVELUP_STAMINAMAXNEXT = 144, // 0x00000090
      [Token(Token = "0x4003072"), GameParameter.ParameterDesc("プレイヤーのレベルアップ前の最大フレンドスロット数")] PLAYERLEVELUP_FRIENDNUM = 145, // 0x00000091
      [Token(Token = "0x4003073"), GameParameter.ParameterDesc("プレイヤーのレベルアップ後の最大フレンドスロット数")] PLAYERLEVELUP_FRIENDNUMNEXT = 146, // 0x00000092
      [Token(Token = "0x4003074"), GameParameter.ParameterDesc("アンロックされた物の説明。インデックスで行数を指定してください。"), GameParameter.UsesIndex] PLAYERLEVELUP_UNLOCKINFO = 147, // 0x00000093
      [Token(Token = "0x4003075"), GameParameter.EnumParameterDesc("プレイ中クエストのボーナス条件の達成状態にあわせてAnimatorのstate(int)、ImageArrayを切り替えます。インデックスでボーナス条件の番号を指定してください。", typeof (QuestBonusObjectiveState)), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes)), GameParameter.UsesIndex] QUEST_BONUSOBJECTIVE_STATE = 148, // 0x00000094
      [Token(Token = "0x4003076")] OBSOLETE_QUEST_BONUSOBJECTIVE_ITEMICON = 149, // 0x00000095
      [Token(Token = "0x4003077")] OBSOLETE_QUEST_BONUSOBJECTIVE_ITEMAMOUNT = 150, // 0x00000096
      [Token(Token = "0x4003078"), GameParameter.EnumParameterDesc("ユニットの陣営にあわせてImageArrayのインデックス、Animatorのindex(int)を切り替えます。", typeof (EUnitSide))] UNIT_SIDE = 151, // 0x00000097
      [Token(Token = "0x4003079"), GameParameter.ParameterDesc("ユニットのジョブのアイコン"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_JOBICON = 152, // 0x00000098
      [Token(Token = "0x400307A"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの現ジョブのアイコン。GameSettingsのJobIcon2のパスを使用する。")] UNIT_JOBICON2 = 153, // 0x00000099
      [Token(Token = "0x400307B"), GameParameter.ParameterDesc("ユニットのIndexで指定したジョブのアイコン。GameSettingsのJobIcon2のパスを使用する。"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.UsesIndex] UNIT_JOB_JOBICON2 = 154, // 0x0000009A
      [Token(Token = "0x400307C"), GameParameter.ParameterDesc("アイテムの作成コスト"), GameParameter.UsesIndex, GameParameter.InstanceTypes(typeof (GameParameter.ItemInstanceTypes))] ITEM_CREATECOST = 155, // 0x0000009B
      [Token(Token = "0x400307D"), GameParameter.ParameterDesc("プレイヤーの現在の洞窟用スタミナ")] GLOBAL_PLAYER_CAVESTAMINA = 156, // 0x0000009C
      [Token(Token = "0x400307E"), GameParameter.ParameterDesc("プレイヤーの最大の洞窟用スタミナ")] GLOBAL_PLAYER_CAVESTAMINAMAX = 157, // 0x0000009D
      [Token(Token = "0x400307F"), GameParameter.ParameterDesc("プレイヤーの洞窟用スタミナが次に回復するまでの時間")] GLOBAL_PLAYER_CAVESTAMINATIME = 158, // 0x0000009E
      [Token(Token = "0x4003080"), GameParameter.InstanceTypes(typeof (GameParameter.ItemInstanceTypes)), GameParameter.ParameterDesc("アイテムの種類ごとの所持上限"), GameParameter.UsesIndex] ITEM_AMOUNTMAX = 159, // 0x0000009F
      [Token(Token = "0x4003081"), GameParameter.ParameterDesc("所持しているアイテムの種類")] PLAYER_NUMITEMS = 160, // 0x000000A0
      [Token(Token = "0x4003082"), GameParameter.ParameterDesc("クエストが通常クエストかエリートクエストかどうかでImageArrayのインデックスを切り替えます。0=通常、1=エリート、2=エクストラ"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes))] QUEST_DIFFICULTY = 161, // 0x000000A1
      [Token(Token = "0x4003083"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの現在位置の高さ")] UNIT_HEIGHT = 162, // 0x000000A2
      [Token(Token = "0x4003084"), GameParameter.UsesIndex, GameParameter.ParameterDesc("装備アイテムの種類にあわせたフレームをImageに設定します。フレームの設定はGameSettings.ItemIconsを参照します。")] EQUIPMENT_FRAME = 163, // 0x000000A3
      [Token(Token = "0x4003085"), GameParameter.ParameterDesc("クエストリストで使用するチャプター(章)の名前")] QUESTLIST_CHAPTERNAME = 164, // 0x000000A4
      [Token(Token = "0x4003086"), GameParameter.ParameterDesc("クエストリストで使用するセクション(部)の名前")] QUESTLIST_SECTIONNAME = 165, // 0x000000A5
      [Token(Token = "0x4003087"), GameParameter.ParameterDesc("メールの文面")] MAIL_MESSAGE = 166, // 0x000000A6
      [Token(Token = "0x4003088"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes)), GameParameter.ParameterDesc("マルチクエストが通常マップかイベントマップかどうかでImageArrayのインデックスを切り替えます。0=通常、1=イベント")] QUEST_MULTI_TYPE = 167, // 0x000000A7
      [Token(Token = "0x4003089"), GameParameter.ParameterDesc("マルチプレイヤーの名前")] MULTI_PLAYER_NAME = 168, // 0x000000A8
      [Token(Token = "0x400308A"), GameParameter.ParameterDesc("マルチプレイヤーのレベル")] MULTI_PLAYER_LEVEL = 169, // 0x000000A9
      [Token(Token = "0x400308B"), GameParameter.InstanceTypes(typeof (PhotonPlayerData.PlayerState)), GameParameter.UsesIndex, GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("マルチプレイヤーの状態( Index: 0 == 否定 / 1 == 完全一致")] MULTI_PLAYER_STATE = 170, // 0x000000AA
      [Token(Token = "0x400308C"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex, GameParameter.ParameterDesc("マルチプレイヤーのユニットアイコン")] MULTI_PLAYER_UNIT_ICON = 171, // 0x000000AB
      [Token(Token = "0x400308D"), GameParameter.ParameterDesc("メールで付与されるアイテムの文字列表現")] MAIL_GIFT_STRING = 172, // 0x000000AC
      [Token(Token = "0x400308E"), GameParameter.ParameterDesc("メールの有効期限")] MAIL_GIFT_LIMIT = 173, // 0x000000AD
      [Token(Token = "0x400308F"), GameParameter.ParameterDesc("メールを既読にした日時")] MAIL_GIFT_GETAT = 174, // 0x000000AE
      [Token(Token = "0x4003090"), GameParameter.ParameterDesc("マルチ部屋リストのコメント")] MULTI_ROOM_LIST_COMMENT = 175, // 0x000000AF
      [Token(Token = "0x4003091"), GameParameter.ParameterDesc("マルチ部屋リストの部屋主名")] MULTI_ROOM_LIST_OWNER_NAME = 176, // 0x000000B0
      [Token(Token = "0x4003092"), GameParameter.ParameterDesc("マルチ部屋リストの部屋主レベル")] MULTI_ROOM_LIST_OWNER_LV = 177, // 0x000000B1
      [Token(Token = "0x4003093"), GameParameter.ParameterDesc("マルチ部屋リストのクエスト名")] MULTI_ROOM_LIST_QUEST_NAME = 178, // 0x000000B2
      [Token(Token = "0x4003094"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex, GameParameter.ParameterDesc("マルチ部屋リストの鍵アイコン. 0:鍵あり 1:鍵なし")] MULTI_ROOM_LIST_LOCKED_ICON = 179, // 0x000000B3
      [Token(Token = "0x4003095"), GameParameter.ParameterDesc("マルチ部屋リストの参加人数")] MULTI_ROOM_LIST_PLAYER_NUM = 180, // 0x000000B4
      [Token(Token = "0x4003096"), GameParameter.ParameterDesc("プレイヤーのフレンドコード")] GLOBAL_PLAYER_FRIENDCODE = 181, // 0x000000B5
      [Token(Token = "0x4003097"), GameParameter.ParameterDesc("フレンドのフレンドコード")] FRIEND_FRIENDCODE = 182, // 0x000000B6
      [Token(Token = "0x4003098"), GameParameter.ParameterDesc("フレンドの名前")] FRIEND_NAME = 183, // 0x000000B7
      [Token(Token = "0x4003099"), GameParameter.ParameterDesc("フレンドのレベル")] FRIEND_LEVEL = 184, // 0x000000B8
      [Token(Token = "0x400309A"), GameParameter.ParameterDesc("フレンドの最終ログイン")] FRIEND_LASTLOGIN = 185, // 0x000000B9
      [Token(Token = "0x400309B"), GameParameter.ParameterDesc("所持可能の最大アイテム数")] PLAYER_MAXITEMS = 186, // 0x000000BA
      [Token(Token = "0x400309C"), GameParameter.ParameterDesc("売却アイテムの選択数分の価格")] SHOP_ITEM_SELLPRICE = 187, // 0x000000BB
      [Token(Token = "0x400309D"), GameParameter.ParameterDesc("売却アイテムの数")] SHOP_ITEM_SELLNUM = 188, // 0x000000BC
      [Token(Token = "0x400309E"), GameParameter.ParameterDesc("売却アイテムの選択インデックス")] SHOP_ITEM_SELLINDEX = 189, // 0x000000BD
      [Token(Token = "0x400309F"), GameParameter.ParameterDesc("売却アイテムの選択数")] SHOP_ITEM_SELLSELECTCOUNT = 190, // 0x000000BE
      [Token(Token = "0x40030A0"), GameParameter.ParameterDesc("ショップ総売却価格")] SHOP_SELLPRICETOTAL = 191, // 0x000000BF
      [Token(Token = "0x40030A1"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("ショップアイテムのインベントリ設定状態で表示状態を切り替え")] SHOP_ITEM_STATE_INVENTORY = 192, // 0x000000C0
      [Token(Token = "0x40030A2"), GameParameter.ParameterDesc("ショップアイテムの設置数を取得")] SHOP_ITEM_BUYAMOUNT = 193, // 0x000000C1
      [Token(Token = "0x40030A3"), GameParameter.ParameterDesc("ショップアイテムの購入総額を取得")] SHOP_ITEM_BUYPRICE = 194, // 0x000000C2
      [Token(Token = "0x40030A4"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("ショップアイテムの売却済み状態で表示状態を切り替え")] SHOP_ITEM_STATE_SOLDOUT = 195, // 0x000000C3
      [Token(Token = "0x40030A5"), GameParameter.ParameterDesc("ショップアイテムの購入通貨別のアイコン"), GameParameter.UsesIndex] SHOP_ITEM_BUYTYPEICON = 196, // 0x000000C4
      [Token(Token = "0x40030A6"), GameParameter.ParameterDesc("ショップアイテムの売却選択状態で表示状態を切り替え"), GameParameter.AlwaysUpdate] SHOP_ITEM_STATE_SELLSELECT = 197, // 0x000000C5
      [Token(Token = "0x40030A7"), GameParameter.ParameterDesc("ショップアイテムのアイコン上の売却数")] SHOP_ITEM_ICONSELLNUM = 198, // 0x000000C6
      [Token(Token = "0x40030A8"), GameParameter.ParameterDesc("装備可能ユニットが存在する場合のバッジアイコンの表示状態の切り替え"), GameParameter.AlwaysUpdate] SHOP_ITEM_STATE_ENABLEEQUIPUNIT = 199, // 0x000000C7
      [Token(Token = "0x40030A9"), GameParameter.ParameterDesc("ショップアイテムの商品一覧の更新時間")] SHOP_ITEM_UPDATETIME = 200, // 0x000000C8
      [Token(Token = "0x40030AA"), GameParameter.ParameterDesc("プレイヤーに来ているフレンド申請通知の数")] PLAYER_FRIENDREQUESTNUM = 201, // 0x000000C9
      [Token(Token = "0x40030AB"), GameParameter.ParameterDesc("ユニットのIndexで指定したジョブのクラスチェンジ先のジョブのアイコン"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.UsesIndex] UNIT_JOB_CLASSCHANGE_JOBICON = 202, // 0x000000CA
      [Token(Token = "0x40030AC"), GameParameter.ParameterDesc("ユニットのIndexで指定したジョブの名前"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.UsesIndex] UNIT_JOB_CLASSCHANGE_NAME = 203, // 0x000000CB
      [Token(Token = "0x40030AD"), GameParameter.ParameterDesc("ユニットのIndexで指定したジョブのクラスチェンジ先のジョブのアイコン"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.UsesIndex] UNIT_JOB_CLASSCHANGE_JOBICON2 = 204, // 0x000000CC
      [Token(Token = "0x40030AE"), GameParameter.ParameterDesc("ショップアイテムのアイコン上の売却数表示切り替え"), GameParameter.AlwaysUpdate] SHOP_ITEM_ICONSELLNUMSHOWED = 205, // 0x000000CD
      [Token(Token = "0x40030AF"), GameParameter.ParameterDesc("プレイヤーのフレンド保持上限")] PLAYER_FRIENDMAX = 206, // 0x000000CE
      [Token(Token = "0x40030B0"), GameParameter.ParameterDesc("プレイヤーの保持しているフレンドの数")] PLAYER_FRIENDNUM = 207, // 0x000000CF
      [Token(Token = "0x40030B1"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの長い説明文")] UNIT_PROFILETEXT = 208, // 0x000000D0
      [Token(Token = "0x40030B2"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットのイメージ画像")] UNIT_IMAGE = 209, // 0x000000D1
      [Token(Token = "0x40030B3"), GameParameter.ParameterDesc("マルチ部屋リストの募集人数")] MULTI_ROOM_LIST_PLAYER_NUM_MAX = 210, // 0x000000D2
      [Token(Token = "0x40030B4"), GameParameter.ParameterDesc("マルチプレイヤーのユニットアイコンフレーム"), GameParameter.UsesIndex, GameParameter.AlwaysUpdate] MULTI_PLAYER_UNIT_ICON_FRAME = 211, // 0x000000D3
      [Token(Token = "0x40030B5"), GameParameter.ParameterDesc("マルチプレイヤーのプレイヤーID")] MULTI_PLAYER_INDEX = 212, // 0x000000D4
      [Token(Token = "0x40030B6"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("マルチプレイヤーが部屋主のときに表示")] MULTI_PLAYER_IS_ROOM_OWNER = 213, // 0x000000D5
      [Token(Token = "0x40030B7"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("マルチプレイヤーがいないときに表示")] MULTI_PLAYER_IS_EMPTY = 214, // 0x000000D6
      [Token(Token = "0x40030B8"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("マルチプレイヤーがいるときに表示")] MULTI_PLAYER_IS_VALID = 215, // 0x000000D7
      [Token(Token = "0x40030B9"), GameParameter.ParameterDesc("実績の名前")] TROPHY_NAME = 216, // 0x000000D8
      [Token(Token = "0x40030BA"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("共闘マルチのとき表示")] MULTI_ROOM_TYPE_IS_RAID = 217, // 0x000000D9
      [Token(Token = "0x40030BB"), GameParameter.ParameterDesc("対戦マルチのとき表示"), GameParameter.AlwaysUpdate] MULTI_ROOM_TYPE_IS_VERSUS = 218, // 0x000000DA
      [Token(Token = "0x40030BC"), GameParameter.ParameterDesc("マルチパーティの総攻撃力")] MULTI_PARTY_TOTALATK = 219, // 0x000000DB
      [Token(Token = "0x40030BD"), GameParameter.ParameterDesc("現在のユニット操作プレイヤーID"), GameParameter.AlwaysUpdate] MULTI_CURRENT_PLAYER_INDEX = 220, // 0x000000DC
      [Token(Token = "0x40030BE"), GameParameter.ParameterDesc("自キャラ行動までの残りターン"), GameParameter.AlwaysUpdate] MULTI_MY_NEXT_TURN = 221, // 0x000000DD
      [Token(Token = "0x40030BF"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("残りの入力制限時間")] MULTI_INPUT_TIME_LIMIT = 222, // 0x000000DE
      [Token(Token = "0x40030C0"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("現在のユニット操作プレイヤー名")] MULTI_CURRENT_PLAYER_NAME = 223, // 0x000000DF
      [Token(Token = "0x40030C1"), GameParameter.ParameterDesc("鍵つき部屋を作るとき表示"), GameParameter.AlwaysUpdate] QUEST_MULTI_LOCK = 224, // 0x000000E0
      [Token(Token = "0x40030C2"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("現在の部屋コメント")] MULTI_CURRENT_ROOM_COMMENT = 225, // 0x000000E1
      [Token(Token = "0x40030C3"), GameParameter.UsesIndex, GameParameter.ParameterDesc("現在の部屋パスコード/0 == 半角 / 1 == 全角")] MULTI_CURRENT_ROOM_PASSCODE = 226, // 0x000000E2
      [Token(Token = "0x40030C4"), GameParameter.ParameterDesc("ユニットが不参加スロット枠のとき表示"), GameParameter.UsesIndex, GameParameter.AlwaysUpdate] MULTI_CURRENT_ROOM_UNIT_SLOT_DISABLE = 227, // 0x000000E3
      [Token(Token = "0x40030C5"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("現在の部屋のクエスト名")] MULTI_CURRENT_ROOM_QUEST_NAME = 228, // 0x000000E4
      [Token(Token = "0x40030C6"), GameParameter.ParameterDesc("マルチプレイのとき非表示(0)/表示(1)/NotInteractive(2)/Interactive(3)/戦闘中アイテムボタン表示設定(4)"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex] QUEST_IS_MULTI = 229, // 0x000000E5
      [Token(Token = "0x40030C7"), GameParameter.ParameterDesc("実績の条件のテキスト"), GameParameter.InstanceTypes(typeof (GameParameter.TrophyConditionInstances)), GameParameter.UsesIndex] TROPHY_CONDITION_TITLE = 230, // 0x000000E6
      [Token(Token = "0x40030C8"), GameParameter.InstanceTypes(typeof (GameParameter.TrophyConditionInstances)), GameParameter.UsesIndex, GameParameter.ParameterDesc("実績の条件のカウント、スライダーにもできるよ")] TROPHY_CONDITION_COUNT = 231, // 0x000000E7
      [Token(Token = "0x40030C9"), GameParameter.UsesIndex, GameParameter.InstanceTypes(typeof (GameParameter.TrophyConditionInstances)), GameParameter.ParameterDesc("実績の条件の必要カウント")] TROPHY_CONDITION_COUNTMAX = 232, // 0x000000E8
      [Token(Token = "0x40030CA"), GameParameter.ParameterDesc("アイテムの素材経験値"), GameParameter.InstanceTypes(typeof (GameParameter.ItemInstanceTypes))] ITEM_ENHANCEPOINT = 233, // 0x000000E9
      [Token(Token = "0x40030CB"), GameParameter.ParameterDesc("装備アイテムの強化素材の選択数")] EQUIPITEM_ENHANCE_MATERIALSELECTCOUNT = 234, // 0x000000EA
      [Token(Token = "0x40030CC"), GameParameter.ParameterDesc("アイテム所持数によって表示状態を変更（0個の場合非表示）"), GameParameter.InstanceTypes(typeof (GameParameter.ItemInstanceTypes)), GameParameter.AlwaysUpdate] ITEM_SHOWED_AMOUNT = 235, // 0x000000EB
      [Token(Token = "0x40030CD"), GameParameter.ParameterDesc("強化パラメータ名")] EQUIPITEM_PARAMETER_NAME = 236, // 0x000000EC
      [Token(Token = "0x40030CE"), GameParameter.ParameterDesc("装備アイテムの初期値")] EQUIPITEM_PARAMETER_INITVALUE = 237, // 0x000000ED
      [Token(Token = "0x40030CF"), GameParameter.ParameterDesc("装備アイテムの上昇値")] EQUIPITEM_PARAMETER_RANKUPVALUE = 238, // 0x000000EE
      [Token(Token = "0x40030D0"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("装備アイテムの上昇量に応じて表示状態を変更")] EQUIPITEM_PARAMETER_SHOWED_RANKUPVALUE = 239, // 0x000000EF
      [Token(Token = "0x40030D1"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("装備アイテムの強化素材の選択個数によって表示状態を変更（選択数が0の場合は非表示）")] EQUIPITEM_ENHANCE_SHOWED_MATERIALSELECTCOUNT = 240, // 0x000000F0
      [Token(Token = "0x40030D2"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("装備アイテムの強化素材の選択状態によって表示状態を変更（選択していない場合は非表示）")] EQUIPITEM_ENHANCE_SHOWED_MATERIALSELECT = 241, // 0x000000F1
      [Token(Token = "0x40030D3"), GameParameter.ParameterDesc("装備アイテムの強化ゲージ")] EQUIPITEM_ENHANCE_GAUGE = 242, // 0x000000F2
      [Token(Token = "0x40030D4"), GameParameter.ParameterDesc("装備アイテムの現在の強化ポイント")] EQUIPITEM_ENHANCE_CURRENTEXP = 243, // 0x000000F3
      [Token(Token = "0x40030D5"), GameParameter.ParameterDesc("装備アイテムのランクアップまでの強化ポイント")] EQUIPITEM_ENHANCE_NEXTEXP = 244, // 0x000000F4
      [Token(Token = "0x40030D6"), GameParameter.ParameterDesc("装備アイテムの強化前のランク")] EQUIPITEM_ENHANCE_RANKBEFORE = 245, // 0x000000F5
      [Token(Token = "0x40030D7"), GameParameter.ParameterDesc("装備アイテムの強化後のランク")] EQUIPITEM_ENHANCE_RANKAFTER = 246, // 0x000000F6
      [Token(Token = "0x40030D8"), GameParameter.ParameterDesc("装備アイテムのランクに応じたイメージを使用します"), GameParameter.AlwaysUpdate] EQUIPDATA_RANKBADGE = 247, // 0x000000F7
      [Token(Token = "0x40030D9"), GameParameter.ParameterDesc("【使用禁止】機能がアンロックされている場合のみ表示"), GameParameter.InstanceTypes(typeof (UnlockTargets))] DONTUSE_UNLOCK_SHOWED = 248, // 0x000000F8
      [Token(Token = "0x40030DA"), GameParameter.ParameterDesc("切断されたプレイヤーIndex")] MULTI_NOTIFY_DISCONNECTED_PLAYER_INDEX = 249, // 0x000000F9
      [Token(Token = "0x40030DB"), GameParameter.ParameterDesc("切断されたプレイヤーが(0:部屋主じゃなかったとき表示 1:他人が部屋主になったとき表示 2:自分が部屋主になったとき表示)"), GameParameter.UsesIndex] MULTI_NOTIFY_DISCONNECTED_PLAYER_IS_ROOM_OWNER = 250, // 0x000000FA
      [Token(Token = "0x40030DC"), GameParameter.ParameterDesc("行動順のプレイヤーが切断されているとき表示(0) 非表示(1)"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex] MULTI_CURRENT_PLAYER_IS_DISCONNECTED = 251, // 0x000000FB
      [Token(Token = "0x40030DD"), GameParameter.ParameterDesc("行動順のプレイヤーが部屋主かどうか"), GameParameter.AlwaysUpdate] MULTI_CURRENT_PLAYER_IS_ROOM_OWNER = 252, // 0x000000FC
      [Token(Token = "0x40030DE"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex, GameParameter.ParameterDesc("自分が部屋主のとき表示(0) 非表示(1)")] MULTI_I_AM_ROOM_OWNER = 253, // 0x000000FD
      [Token(Token = "0x40030DF"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("部屋主のプレイヤーIndex")] MULTI_ROOM_OWNER_PLAYER_INDEX = 254, // 0x000000FE
      [Token(Token = "0x40030E0"), GameParameter.ParameterDesc("ガチャでドロップしたものの名称")] GACHA_DROPNAME = 255, // 0x000000FF
      [Token(Token = "0x40030E1"), GameParameter.ParameterDesc("達成済みデイリーミッションの有無で表示状態を切り替える"), GameParameter.InstanceTypes(typeof (GameParameter.TrophyBadgeInstanceTypes)), GameParameter.AlwaysUpdate] TROPHY_BADGE = 256, // 0x00000100
      [Token(Token = "0x40030E2"), GameParameter.ParameterDesc("実績の報酬ゴールド。ゴールドが0なら自身を非表示にする。"), GameParameter.AlwaysUpdate] TROPHY_REWARDGOLD = 257, // 0x00000101
      [Token(Token = "0x40030E3"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("実績の報酬コイン。コインが0なら自身を非表示にする。")] TROPHY_REWARDCOIN = 258, // 0x00000102
      [Token(Token = "0x40030E4"), GameParameter.ParameterDesc("実績の報酬プレイヤー経験値。経験値が0なら自身を非表示にする。"), GameParameter.AlwaysUpdate] TROPHY_REWARDEXP = 259, // 0x00000103
      [Token(Token = "0x40030E5"), GameParameter.ParameterDesc("報酬に含まれる経験値")] REWARD_EXP = 260, // 0x00000104
      [Token(Token = "0x40030E6"), GameParameter.ParameterDesc("報酬に含まれるコイン")] REWARD_COIN = 261, // 0x00000105
      [Token(Token = "0x40030E7"), GameParameter.ParameterDesc("報酬に含まれるゴールド")] REWARD_GOLD = 262, // 0x00000106
      [Token(Token = "0x40030E8"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("ユニットのお気に入りロック状態")] UNIT_FAVORITE = 263, // 0x00000107
      [Token(Token = "0x40030E9"), GameParameter.UsesIndex, GameParameter.InstanceTypes(typeof (GameParameter.ItemInstanceTypes)), GameParameter.ParameterDesc("装備アイテムの種類にあわせたフレームをImageに設定します。フレームの設定はGameSettings.ItemIconsを参照します。")] EQUIPDATA_FRAME = 264, // 0x00000108
      [Token(Token = "0x40030EA"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ジョブのランクにあわせてImageArrayを切り替えます")] UNIT_JOBRANKFRAME = 265, // 0x00000109
      [Token(Token = "0x40030EB"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ローカルプレイヤーのレベルによってキャップされたユニットの最大レベル")] UNIT_CAPPEDLEVELMAX = 266, // 0x0000010A
      [Token(Token = "0x40030EC"), GameParameter.ParameterDesc("リビジョン番号")] APPLICATION_REVISION = 267, // 0x0000010B
      [Token(Token = "0x40030ED"), GameParameter.ParameterDesc("ビルドID")] APPLICATION_BUILD = 268, // 0x0000010C
      [Token(Token = "0x40030EE"), GameParameter.ParameterDesc("アセットのリビジョン番号")] APPLICATION_ASSETREVISION = 269, // 0x0000010D
      [Token(Token = "0x40030EF"), GameParameter.ParameterDesc("プロダクト名称")] PRODUCT_NAME = 270, // 0x0000010E
      [Token(Token = "0x40030F0"), GameParameter.ParameterDesc("プロダクト値段")] PRODUCT_PRICE = 271, // 0x0000010F
      [Token(Token = "0x40030F1"), GameParameter.InstanceTypes(typeof (GameParameter.ArenaPlayerInstanceTypes)), GameParameter.ParameterDesc("アリーナプレイヤーの順位")] ARENAPLAYER_RANK = 272, // 0x00000110
      [Token(Token = "0x40030F2"), GameParameter.InstanceTypes(typeof (GameParameter.ArenaPlayerInstanceTypes)), GameParameter.ParameterDesc("アリーナプレイヤーの総攻撃力")] ARENAPLAYER_TOTALATK = 273, // 0x00000111
      [Token(Token = "0x40030F3"), GameParameter.InstanceTypes(typeof (GameParameter.ArenaPlayerInstanceTypes)), GameParameter.ParameterDesc("アリーナプレイヤーのリーダースキル")] ARENAPLAYER_LEADERSKILLNAME = 274, // 0x00000112
      [Token(Token = "0x40030F4"), GameParameter.ParameterDesc("アリーナプレイヤーのリーダースキルの説明"), GameParameter.InstanceTypes(typeof (GameParameter.ArenaPlayerInstanceTypes))] ARENAPLAYER_LEADERSKILLDESC = 275, // 0x00000113
      [Token(Token = "0x40030F5"), GameParameter.ParameterDesc("アリーナプレイヤーの名前"), GameParameter.InstanceTypes(typeof (GameParameter.ArenaPlayerInstanceTypes))] ARENAPLAYER_NAME = 276, // 0x00000114
      [Token(Token = "0x40030F6"), GameParameter.ParameterDesc("プレイヤーのアリーナランク")] GLOBAL_PLAYER_ARENARANK = 277, // 0x00000115
      [Token(Token = "0x40030F7"), GameParameter.ParameterDesc("チケット数")] QUEST_TICKET = 278, // 0x00000116
      [Token(Token = "0x40030F8"), GameParameter.ParameterDesc("チケット使用可能な場合のみ表示"), GameParameter.AlwaysUpdate] QUEST_IS_TICKET = 279, // 0x00000117
      [Token(Token = "0x40030F9"), GameParameter.ParameterDesc("アリーナの挑戦権")] GLOBAL_PLAYER_ARENATICKETS = 280, // 0x00000118
      [Token(Token = "0x40030FA"), GameParameter.ParameterDesc("アリーナのクールダウンタイム")] GLOBAL_PLAYER_ARENACOOLDOWNTIME = 281, // 0x00000119
      [Token(Token = "0x40030FB"), GameParameter.ParameterDesc("本日のマルチプレイ残り報酬獲得回数")] MULTI_REST_REWARD = 282, // 0x0000011A
      [Token(Token = "0x40030FC"), GameParameter.ParameterDesc("ユニットが不参加スロット枠のとき押せない"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex] MULTI_CURRENT_ROOM_UNIT_SLOT_DISABLE_NOT_INTERACTIVE = 283, // 0x0000011B
      [Token(Token = "0x40030FD"), GameParameter.ParameterDesc("お客様コード")] GLOBAL_PLAYER_OKYAKUSAMACODE = 284, // 0x0000011C
      [Token(Token = "0x40030FE"), GameParameter.ParameterDesc("【使用禁止】機能がアンロックされている場合のみ有効"), GameParameter.InstanceTypes(typeof (UnlockTargets))] DONTUSE_UNLOCK_ENABLED = 285, // 0x0000011D
      [Token(Token = "0x40030FF"), GameParameter.ParameterDesc("【使用禁止】機能がアンロックされていると表示されなくなる"), GameParameter.InstanceTypes(typeof (UnlockTargets)), GameParameter.AlwaysUpdate] DONTUSE_UNLOCK_HIDDEN = 286, // 0x0000011E
      [Token(Token = "0x4003100"), GameParameter.ParameterDesc("報酬に含まれるアリーナメダル")] REWARD_ARENAMEDAL = 287, // 0x0000011F
      [Token(Token = "0x4003101"), GameParameter.ParameterDesc("ショップアイテムの商品一覧の更新日")] SHOP_ITEM_UPDATEDAY = 288, // 0x00000120
      [Token(Token = "0x4003102"), GameParameter.ParameterDesc("アリーナプレイヤーのレベル"), GameParameter.InstanceTypes(typeof (GameParameter.ArenaPlayerInstanceTypes))] ARENAPLAYER_LEVEL = 289, // 0x00000121
      [Token(Token = "0x4003103"), GameParameter.ParameterDesc("プレイヤーのVIPランク")] GLOBAL_PLAYER_VIPRANK = 290, // 0x00000122
      [Token(Token = "0x4003104"), GameParameter.ParameterDesc("ユニットの装備品を更新"), GameParameter.UsesIndex] UNIT_EQUIPSLOT_UPDATE = 291, // 0x00000123
      [Token(Token = "0x4003105"), GameParameter.ParameterDesc("ユニットパラメータ指定の初期状態でのアイコン表示")] UNITPARAM_ICON = 292, // 0x00000124
      [Token(Token = "0x4003106"), GameParameter.ParameterDesc("ユニットパラメータ指定の初期状態でのレアリティ")] UNITPARAM_RARITY = 293, // 0x00000125
      [Token(Token = "0x4003107"), GameParameter.ParameterDesc("ユニットパラメータ指定の初期状態でのジョブアイコン")] UNITPARAM_JOBICON = 294, // 0x00000126
      [Token(Token = "0x4003108"), GameParameter.ParameterDesc("ユニットパラメータ指定の初期状態での欠片所持数")] UNITPARAM_PIECE_AMOUNT = 295, // 0x00000127
      [Token(Token = "0x4003109"), GameParameter.ParameterDesc("ユニットパラメータ指定の初期状態での欠片必要数")] UNITPARAM_PIECE_NEED = 296, // 0x00000128
      [Token(Token = "0x400310A"), GameParameter.ParameterDesc("ユニットパラメータ指定の初期状態での欠片ゲージ")] UNITPARAM_PIECE_GAUGE = 297, // 0x00000129
      [Token(Token = "0x400310B"), GameParameter.ParameterDesc("ユニットパラメータ指定でアンロック可能か確認"), GameParameter.AlwaysUpdate] UNITPARAM_IS_UNLOCKED = 298, // 0x0000012A
      [Token(Token = "0x400310C"), GameParameter.ParameterDesc("クエストで入手可能な欠片のフレーム"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes))] QUEST_KAKERA_FRAME = 299, // 0x0000012B
      [Token(Token = "0x400310D"), GameParameter.ParameterDesc("ユニットの連携値"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_COMBINATION = 300, // 0x0000012C
      [Token(Token = "0x400310E"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("ユニットのジョブ変更可能か確認"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_STATE_JOBCHANGED = 301, // 0x0000012D
      [Token(Token = "0x400310F"), GameParameter.ParameterDesc("ショップの主要通貨の表示状態"), GameParameter.AlwaysUpdate] SHOP_STATE_MAINCOSTFRAME = 302, // 0x0000012E
      [Token(Token = "0x4003110"), GameParameter.ParameterDesc("ショップの主要通貨アイコン")] SHOP_MAINCOST_ICON = 303, // 0x0000012F
      [Token(Token = "0x4003111"), GameParameter.ParameterDesc("ショップの主要通貨の所持量")] SHOP_MAINCOST_AMOUNT = 304, // 0x00000130
      [Token(Token = "0x4003112"), GameParameter.ParameterDesc("対象ユニットの成長バッジ"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.AlwaysUpdate] UNIT_BADGE_GROWUP = 305, // 0x00000131
      [Token(Token = "0x4003113"), GameParameter.ParameterDesc("対象ユニットの解放バッジ"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNITPARAM_BADGE_UNLOCK = 306, // 0x00000132
      [Token(Token = "0x4003114"), GameParameter.InstanceTypes(typeof (GameParameter.ItemInstanceTypes)), GameParameter.ParameterDesc("アイテムで装備可能なユニットが存在する場合に表示状態を変更するバッジ"), GameParameter.AlwaysUpdate] ITEM_BADGE_EQUIPUNIT = 307, // 0x00000133
      [Token(Token = "0x4003115"), GameParameter.ParameterDesc("ユニットのバッジ表示状態を変更"), GameParameter.AlwaysUpdate] BADGE_UNIT = 308, // 0x00000134
      [Token(Token = "0x4003116"), GameParameter.ParameterDesc("ユニット強化のバッジ表示状態を変更"), GameParameter.AlwaysUpdate] BADGE_UNITENHANCED = 309, // 0x00000135
      [Token(Token = "0x4003117"), GameParameter.ParameterDesc("ユニット開放のバッジ表示状態を変更"), GameParameter.AlwaysUpdate] BADGE_UNITUNLOCKED = 310, // 0x00000136
      [Token(Token = "0x4003118"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("ガチャのバッジ表示状態を変更")] BADGE_GACHA = 311, // 0x00000137
      [Token(Token = "0x4003119"), GameParameter.ParameterDesc("ゴールドガチャのバッジ表示状態を変更"), GameParameter.AlwaysUpdate] BADGE_GOLDGACHA = 312, // 0x00000138
      [Token(Token = "0x400311A"), GameParameter.ParameterDesc("レアガチャのバッジ表示状態を変更"), GameParameter.AlwaysUpdate] BADGE_RAREGACHA = 313, // 0x00000139
      [Token(Token = "0x400311B"), GameParameter.ParameterDesc("アリーナのバッジ表示状態を変更"), GameParameter.AlwaysUpdate] BADGE_ARENA = 314, // 0x0000013A
      [Token(Token = "0x400311C"), GameParameter.ParameterDesc("マルチプレイのバッジ表示状態を変更"), GameParameter.AlwaysUpdate] BADGE_MULTIPLAY = 315, // 0x0000013B
      [Token(Token = "0x400311D"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("デイリーミッションのバッジ表示状態を変更")] BADGE_DAILYMISSION = 316, // 0x0000013C
      [Token(Token = "0x400311E"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("フレンドのバッジ表示状態を変更")] BADGE_FRIEND = 317, // 0x0000013D
      [Token(Token = "0x400311F"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("ギフトのバッジ表示状態を変更")] BADGE_GIFTBOX = 318, // 0x0000013E
      [Token(Token = "0x4003120"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("ショートカットメニューのバッジ表示状態を変更")] BADGE_SHORTCUTMENU = 319, // 0x0000013F
      [Token(Token = "0x4003121"), GameParameter.ParameterDesc("現VIPランクにおけるVIPポイント。スライダー対応")] GLOBAL_PLAYER_VIPPOINT = 320, // 0x00000140
      [Token(Token = "0x4003122"), GameParameter.ParameterDesc("現VIPランクにおける最大VIPポイント")] GLOBAL_PLAYER_VIPPOINTMAX = 321, // 0x00000141
      [Token(Token = "0x4003123"), GameParameter.ParameterDesc("プレイヤーの所持コイン (固有無償幻晶石)")] GLOBAL_PLAYER_COINFREE = 322, // 0x00000142
      [Token(Token = "0x4003124"), GameParameter.ParameterDesc("プレイヤーの所持コイン (固有有償幻晶石)")] GLOBAL_PLAYER_COINPAID = 323, // 0x00000143
      [Token(Token = "0x4003125"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("ユニットが編成中のパーティメンバーか？"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_STATE_PARTYMEMBER = 324, // 0x00000144
      [Token(Token = "0x4003126"), GameParameter.ParameterDesc("ログインボーナスの日付")] LOGINBONUS_DAYNUM = 325, // 0x00000145
      [Token(Token = "0x4003127")] None = 326, // 0x00000146
      [Token(Token = "0x4003128"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットがレベルソート中か？"), GameParameter.AlwaysUpdate] UNIT_STATE_LVSORT = 327, // 0x00000147
      [Token(Token = "0x4003129"), GameParameter.ParameterDesc("ユニットがパラメータソート中か？"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.AlwaysUpdate] UNIT_STATE_PARAMSORT = 328, // 0x00000148
      [Token(Token = "0x400312A"), GameParameter.ParameterDesc("ユニットのソート対象パラメータの値"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_SORTTYPE_VALUE = 329, // 0x00000149
      [Token(Token = "0x400312B"), GameParameter.ParameterDesc("スキルの修得条件の表示有無"), GameParameter.AlwaysUpdate] SKILL_STATE_CONDITION = 330, // 0x0000014A
      [Token(Token = "0x400312C"), GameParameter.ParameterDesc("スキルの修得条件")] SKILL_CONDITION = 331, // 0x0000014B
      [Token(Token = "0x400312D"), GameParameter.ParameterDesc("アビリティの修得条件")] ABILITY_CONDITION = 332, // 0x0000014C
      [Token(Token = "0x400312E"), GameParameter.ParameterDesc("ガチャのコスト")] GACHA_COST = 333, // 0x0000014D
      [Token(Token = "0x400312F"), GameParameter.ParameterDesc("ガチャの回数")] GACHA_NUM = 334, // 0x0000014E
      [Token(Token = "0x4003130"), GameParameter.ParameterDesc("無料通常ガチャの残り回数")] GACHA_GOLD_RESTNUM = 335, // 0x0000014F
      [Token(Token = "0x4003131"), GameParameter.ParameterDesc("無料通常ガチャの残り回数の表示状態変更")] GACHA_GOLD_STATE_RESTNUM = 336, // 0x00000150
      [Token(Token = "0x4003132"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("無料通常ガチャのインターバル時間表示")] GACHA_GOLD_TIMER = 337, // 0x00000151
      [Token(Token = "0x4003133"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("無料通常ガチャの状態によって表示状態変更")] GACHA_GOLD_STATE_TIMER = 338, // 0x00000152
      [Token(Token = "0x4003134"), GameParameter.ParameterDesc("無料通常ガチャのボタン状態変更"), GameParameter.AlwaysUpdate] GACHA_GOLD_STATE_INTERACTIVE = 339, // 0x00000153
      [Token(Token = "0x4003135"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("無料レアガチャのインターバル時間表示")] GACHA_COIN_TIMER = 340, // 0x00000154
      [Token(Token = "0x4003136"), GameParameter.ParameterDesc("無料レアガチャの状態によって表示状態変更"), GameParameter.AlwaysUpdate] GACHA_COIN_STATE_TIMER = 341, // 0x00000155
      [Token(Token = "0x4003137"), GameParameter.ParameterDesc("無料レアガチャのボタン状態変更"), GameParameter.AlwaysUpdate] GACHA_COIN_STATE_INTERACTIVE = 342, // 0x00000156
      [Token(Token = "0x4003138"), GameParameter.ParameterDesc("ユニットのイメージ画像2"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_IMAGE2 = 343, // 0x00000157
      [Token(Token = "0x4003139"), GameParameter.ParameterDesc("アイテムのフレーバーテキスト"), GameParameter.InstanceTypes(typeof (GameParameter.ItemInstanceTypes)), GameParameter.UsesIndex] ITEM_FLAVOR = 344, // 0x00000158
      [Token(Token = "0x400313A"), GameParameter.ParameterDesc("ユニット覚醒レベル"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.AlwaysUpdate, GameParameter.UsesIndex] UNIT_AWAKE = 345, // 0x00000159
      [Token(Token = "0x400313B"), GameParameter.ParameterDesc("ユニットがフレンドか？"), GameParameter.AlwaysUpdate] SUPPORTER_ISFRIEND = 346, // 0x0000015A
      [Token(Token = "0x400313C"), GameParameter.ParameterDesc("ユニット覚醒レベル")] SUPPORTER_COST = 347, // 0x0000015B
      [Token(Token = "0x400313D"), GameParameter.ParameterDesc("サムネイル化されたジョブのアイコンをImageコンポーネントに設定します"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] Unit_ThumbnailedJobIcon = 348, // 0x0000015C
      [Token(Token = "0x400313E"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex, GameParameter.ParameterDesc("マルチプレイヤーのユニットジョブランクフレーム")] MULTI_PLAYER_UNIT_JOBRANKFRAME = 349, // 0x0000015D
      [Token(Token = "0x400313F"), GameParameter.ParameterDesc("マルチプレイヤーのユニットジョブランク"), GameParameter.UsesIndex, GameParameter.AlwaysUpdate] MULTI_PLAYER_UNIT_JOBRANK = 350, // 0x0000015E
      [Token(Token = "0x4003140"), GameParameter.ParameterDesc("マルチプレイヤーのユニットジョブアイコン"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex] MULTI_PLAYER_UNIT_JOBICON = 351, // 0x0000015F
      [Token(Token = "0x4003141"), GameParameter.ParameterDesc("マルチプレイヤーのユニットレア度"), GameParameter.UsesIndex, GameParameter.AlwaysUpdate] MULTI_PLAYER_UNIT_RARITY = 352, // 0x00000160
      [Token(Token = "0x4003142"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("マルチプレイヤーのユニット属性"), GameParameter.UsesIndex] MULTI_PLAYER_UNIT_ELEMENT = 353, // 0x00000161
      [Token(Token = "0x4003143"), GameParameter.ParameterDesc("マルチプレイヤーのユニットレベル"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex] MULTI_PLAYER_UNIT_LEVEL = 354, // 0x00000162
      [Token(Token = "0x4003144"), GameParameter.ParameterDesc("実績の報酬スタミナ。スタミナが0なら自身を非表示にする。"), GameParameter.AlwaysUpdate] TROPHY_REWARDSTAMINA = 355, // 0x00000163
      [Token(Token = "0x4003145"), GameParameter.ParameterDesc("ジョブアイコン")] JOB_JOBICON = 356, // 0x00000164
      [Token(Token = "0x4003146"), GameParameter.ParameterDesc("ジョブ名")] JOB_NAME = 357, // 0x00000165
      [Token(Token = "0x4003147"), GameParameter.ParameterDesc("クエストでプレイヤーが得たマルチコイン")] QUESTRESULT_MULTICOIN = 358, // 0x00000166
      [Token(Token = "0x4003148"), GameParameter.UsesIndex, GameParameter.ParameterDesc("本日のマルチプレイ残り報酬獲得回数が0のとき表示(0)/非表示(1)/受け取れたとき表示(2)/受け取れなかったとき表示(3)/今回が最後のうけとりのとき表示(4)")] MULTI_REST_REWARD_IS_ZERO = 359, // 0x00000167
      [Token(Token = "0x4003149"), GameParameter.UsesIndex, GameParameter.ParameterDesc("ユニットが参加スロット枠のとき表示"), GameParameter.AlwaysUpdate] MULTI_CURRENT_ROOM_UNIT_SLOT_ENABLE = 360, // 0x00000168
      [Token(Token = "0x400314A"), GameParameter.ParameterDesc("ユニットが割り当てられているスロット枠のとき表示"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex] MULTI_CURRENT_ROOM_UNIT_SLOT_VALID = 361, // 0x00000169
      [Token(Token = "0x400314B"), GameParameter.ParameterDesc("報酬に含まれるスタミナ")] REWARD_STAMINA = 362, // 0x0000016A
      [Token(Token = "0x400314C"), GameParameter.ParameterDesc("当日クエストに挑戦した回数")] QUEST_CHALLENGE_NUM = 363, // 0x0000016B
      [Token(Token = "0x400314D"), GameParameter.ParameterDesc("当日クエストに挑戦できる限度")] QUEST_CHALLENGE_MAX = 364, // 0x0000016C
      [Token(Token = "0x400314E"), GameParameter.ParameterDesc("クエストの挑戦回数をリセットした数")] QUEST_RESET_NUM = 365, // 0x0000016D
      [Token(Token = "0x400314F"), GameParameter.ParameterDesc("クエストの挑戦回数をリセットできる限度")] QUEST_RESET_MAX = 366, // 0x0000016E
      [Token(Token = "0x4003150"), GameParameter.ParameterDesc("ジョブアイコン2")] JOB_JOBICON2 = 367, // 0x0000016F
      [Token(Token = "0x4003151"), GameParameter.ParameterDesc("ユニットの国"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] OBSOLETE_UNIT_PROFILE_COUNTRY = 368, // 0x00000170
      [Token(Token = "0x4003152"), GameParameter.ParameterDesc("ユニットの身長"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] OBSOLETE_UNIT_PROFILE_HEIGHT = 369, // 0x00000171
      [Token(Token = "0x4003153"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの体重")] OBSOLETE_UNIT_PROFILE_WEIGHT = 370, // 0x00000172
      [Token(Token = "0x4003154"), GameParameter.ParameterDesc("ユニットの誕生日"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] OBSOLETE_UNIT_PROFILE_BIRTHDAY = 371, // 0x00000173
      [Token(Token = "0x4003155"), GameParameter.ParameterDesc("ユニットの星座"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] OBSOLETE_UNIT_PROFILE_ZODIAC = 372, // 0x00000174
      [Token(Token = "0x4003156"), GameParameter.ParameterDesc("ユニットの血液型"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] OBSOLETE_UNIT_PROFILE_BLOOD = 373, // 0x00000175
      [Token(Token = "0x4003157"), GameParameter.ParameterDesc("ユニットの好きなもの"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] OBSOLETE_UNIT_PROFILE_FAVORITE = 374, // 0x00000176
      [Token(Token = "0x4003158"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの趣味")] OBSOLETE_UNIT_PROFILE_HOBBY = 375, // 0x00000177
      [Token(Token = "0x4003159"), GameParameter.ParameterDesc("ユニットの状態異常【毒】"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_STATE_CONDITION_POISON = 376, // 0x00000178
      [Token(Token = "0x400315A"), GameParameter.ParameterDesc("ユニットの状態異常【麻痺】"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.AlwaysUpdate] UNIT_STATE_CONDITION_PARALYSED = 377, // 0x00000179
      [Token(Token = "0x400315B"), GameParameter.ParameterDesc("ユニットの状態異常【スタン】"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.AlwaysUpdate] UNIT_STATE_CONDITION_STUN = 378, // 0x0000017A
      [Token(Token = "0x400315C"), GameParameter.AlwaysUpdate, GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの状態異常【睡眠】")] UNIT_STATE_CONDITION_SLEEP = 379, // 0x0000017B
      [Token(Token = "0x400315D"), GameParameter.ParameterDesc("ユニットの状態異常【魅了】"), GameParameter.AlwaysUpdate, GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_STATE_CONDITION_CHARM = 380, // 0x0000017C
      [Token(Token = "0x400315E"), GameParameter.AlwaysUpdate, GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの状態異常【石化】")] UNIT_STATE_CONDITION_STONE = 381, // 0x0000017D
      [Token(Token = "0x400315F"), GameParameter.ParameterDesc("ユニットの状態異常【暗闇】"), GameParameter.AlwaysUpdate, GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_STATE_CONDITION_BLINDNESS = 382, // 0x0000017E
      [Token(Token = "0x4003160"), GameParameter.ParameterDesc("ユニットの状態異常【沈黙】"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.AlwaysUpdate] UNIT_STATE_CONDITION_DISABLESKILL = 383, // 0x0000017F
      [Token(Token = "0x4003161"), GameParameter.ParameterDesc("ユニットの状態異常【移動禁止】"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.AlwaysUpdate] UNIT_STATE_CONDITION_DISABLEMOVE = 384, // 0x00000180
      [Token(Token = "0x4003162"), GameParameter.AlwaysUpdate, GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの状態異常【攻撃禁止】")] UNIT_STATE_CONDITION_DISABLEATTACK = 385, // 0x00000181
      [Token(Token = "0x4003163"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの状態異常【ゾンビ化・狂乱】"), GameParameter.AlwaysUpdate] UNIT_STATE_CONDITION_ZOMBIE = 386, // 0x00000182
      [Token(Token = "0x4003164"), GameParameter.ParameterDesc("ユニットの状態異常【死の宣告】"), GameParameter.AlwaysUpdate, GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_STATE_CONDITION_DEATHSENTENCE = 387, // 0x00000183
      [Token(Token = "0x4003165"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの状態異常【狂化】"), GameParameter.AlwaysUpdate] UNIT_STATE_CONDITION_BERSERK = 388, // 0x00000184
      [Token(Token = "0x4003166"), GameParameter.ParameterDesc("ユニットの状態異常【ノックバック無効】"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.AlwaysUpdate] UNIT_STATE_CONDITION_DISABLEKNOCKBACK = 389, // 0x00000185
      [Token(Token = "0x4003167"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("ユニットの状態異常【バフ無効】"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_STATE_CONDITION_DISABLEBUFF = 390, // 0x00000186
      [Token(Token = "0x4003168"), GameParameter.AlwaysUpdate, GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの状態異常【デバフ無効】")] UNIT_STATE_CONDITION_DISABLEDEBUFF = 391, // 0x00000187
      [Token(Token = "0x4003169"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ターン表示のユニット陣営フレーム"), GameParameter.AlwaysUpdate] TURN_UNIT_SIDE_FRAME = 392, // 0x00000188
      [Token(Token = "0x400316A"), GameParameter.ParameterDesc("JobSetの開放条件")] JOBSET_UNLOCKCONDITION = 393, // 0x00000189
      [Token(Token = "0x400316B"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex, GameParameter.ParameterDesc("マルチで自キャラ生存数が0のとき表示(0)/非表示(1)")] MULTI_REST_MY_UNIT_IS_ZERO = 394, // 0x0000018A
      [Token(Token = "0x400316C"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex, GameParameter.ParameterDesc("マルチ部屋画面で対象プレイヤーが自分のとき0:表示/1:非表示/2:ImageArrayのインデックス切り替え(0=自分 1=他人)/3:チーム編成ボタン/4:情報をみるボタン/5:チーム編成ボタン(マルチ塔)/6:プレイヤーがまだリザルト画面に存在するか/7:ペアマルチ時の2体目のユニットが存在すれば表示")] MULTI_PLAYER_IS_ME = 395, // 0x0000018B
      [Token(Token = "0x400316D"), GameParameter.ParameterDesc("クエストリストで使用するセクション(部)の説明")] QUESTLIST_SECTIONEXPR = 396, // 0x0000018C
      [Token(Token = "0x400316E"), GameParameter.ParameterDesc("マルチプレイの部屋に鍵がかかっているとき表示(0)/非表示(1)/部屋主かつ鍵ありで表示(2)/部屋主かつ鍵なしで表示(3)"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex] MULTI_CURRENT_ROOM_IS_LOCKED = 397, // 0x0000018D
      [Token(Token = "0x400316F"), GameParameter.ParameterDesc("メールの受け取り日時")] MAIL_GIFT_RECEIVE = 398, // 0x0000018E
      [Token(Token = "0x4003170"), GameParameter.ParameterDesc("クエストのタイムリミット")] QUEST_TIMELIMIT = 399, // 0x0000018F
      [Token(Token = "0x4003171"), GameParameter.ParameterDesc("ユニットの現在のチャージタイム")] UNIT_CHARGETIME = 400, // 0x00000190
      [Token(Token = "0x4003172"), GameParameter.ParameterDesc("ユニットのチャージタイム")] UNIT_CHARGETIMEMAX = 401, // 0x00000191
      [Token(Token = "0x4003173"), GameParameter.ParameterDesc("ギミックオブジェクトの説明文")] GIMMICK_DESCRIPTION = 402, // 0x00000192
      [Token(Token = "0x4003174"), GameParameter.UsesIndex, GameParameter.ParameterDesc("プロダクトDesc 0:そのまま 1:前半 2:後半")] PRODUCT_DESC = 403, // 0x00000193
      [Token(Token = "0x4003175"), GameParameter.ParameterDesc("プロダクト個数 (x10)")] PRODUCT_NUMX = 404, // 0x00000194
      [Token(Token = "0x4003176"), GameParameter.ParameterDesc("ユニットの器用さ (ver1.1以降で表示されます)"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_DEX = 405, // 0x00000195
      [Token(Token = "0x4003177"), GameParameter.UsesIndex, GameParameter.InstanceTypes(typeof (GameParameter.ArtifactInstanceTypes)), GameParameter.ParameterDesc("アーティファクトの名前")] ARTIFACT_NAME = 406, // 0x00000196
      [Token(Token = "0x4003178"), GameParameter.ParameterDesc("アーティファクトのフレーバーテキスト")] ARTIFACT_DESC = 407, // 0x00000197
      [Token(Token = "0x4003179"), GameParameter.ParameterDesc("アーティファクトのボーナス条件")] ARTIFACT_SPEC = 408, // 0x00000198
      [Token(Token = "0x400317A"), GameParameter.ParameterDesc("アーティファクトのレアリティ")] ARTIFACT_RARITY = 409, // 0x00000199
      [Token(Token = "0x400317B"), GameParameter.ParameterDesc("アーティファクトのレアリティ (最大)")] ARTIFACT_RARITYCAP = 410, // 0x0000019A
      [Token(Token = "0x400317C"), GameParameter.ParameterDesc("アーティファクトの所持数")] ARTIFACT_NUM = 411, // 0x0000019B
      [Token(Token = "0x400317D"), GameParameter.ParameterDesc("アーティファクトの売却額")] ARTIFACT_SELLPRICE = 412, // 0x0000019C
      [Token(Token = "0x400317E"), GameParameter.ParameterDesc("アプリのバンドルバージョン")] APPLICATION_VERSION = 413, // 0x0000019D
      [Token(Token = "0x400317F"), GameParameter.ParameterDesc("フレンドユニットの最大レベル")] SUPPORTER_UNITCAPPEDLEVELMAX = 414, // 0x0000019E
      [Token(Token = "0x4003180"), GameParameter.ParameterDesc("欠片ポイント")] GLOBAL_PLAYER_PIECEPOINT = 415, // 0x0000019F
      [Token(Token = "0x4003181"), GameParameter.ParameterDesc("ショップ欠片ポイント総売却価格")] SHOP_KAKERA_SELLPRICETOTAL = 416, // 0x000001A0
      [Token(Token = "0x4003182"), GameParameter.UsesIndex, GameParameter.InstanceTypes(typeof (GameParameter.ItemInstanceTypes)), GameParameter.ParameterDesc("魂の欠片の売却価格")] ITEM_KAKERA_PRICE = 417, // 0x000001A1
      [Token(Token = "0x4003183"), GameParameter.ParameterDesc("魂の欠片変換の選択数分の価格")] SHOP_ITEM_KAKERA_SELLPRICE = 418, // 0x000001A2
      [Token(Token = "0x4003184"), GameParameter.ParameterDesc("報酬に含まれるマルチコイン")] REWARD_MULTICOIN = 419, // 0x000001A3
      [Token(Token = "0x4003185"), GameParameter.ParameterDesc("報酬に含まれる欠片ポイント")] REWARD_KAKERACOIN = 420, // 0x000001A4
      [Token(Token = "0x4003186"), GameParameter.UsesIndex, GameParameter.ParameterDesc("クエスト出撃条件 (0)改行表記、指定文字なし/(1)一行表記、指定文字付/(2)改行表記、指定文字付")] QUEST_UNIT_ENTRYCONDITION = 421, // 0x000001A5
      [Token(Token = "0x4003187"), GameParameter.UsesIndex, GameParameter.ParameterDesc("クエスト出撃条件が設定されている場合に表示(0)/非表示(1)"), GameParameter.AlwaysUpdate] OBSOLETE_QUEST_IS_UNIT_ENTRYCONDITION = 422, // 0x000001A6
      [Token(Token = "0x4003188"), GameParameter.AlwaysUpdate, GameParameter.SerializeGameObjects, GameParameter.ParameterDesc("クエストにユニットが出撃可能な場合に表示(0)/非表示(1)"), GameParameter.UsesIndex] QUEST_IS_UNIT_ENABLEENTRYCONDITION = 423, // 0x000001A7
      [Token(Token = "0x4003189"), GameParameter.ParameterDesc("キャラクタークエスト：エピソード解放条件")] QUEST_CHARACTER_MAINUNITCONDITION = 424, // 0x000001A8
      [Token(Token = "0x400318A"), GameParameter.ParameterDesc("キャラクタークエスト：話数")] QUEST_CHARACTER_EPISODENUM = 425, // 0x000001A9
      [Token(Token = "0x400318B"), GameParameter.ParameterDesc("キャラクタークエスト：エピソード名")] QUEST_CHARACTER_EPISODENAME = 426, // 0x000001AA
      [Token(Token = "0x400318C"), GameParameter.ParameterDesc("限定ショップアイテムの残り購入可能数を取得")] SHOP_LIMITED_ITEM_BUYAMOUNT = 427, // 0x000001AB
      [Token(Token = "0x400318D"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex, GameParameter.ParameterDesc("ユニットのIndexで指定したジョブがマスターしている場合に表示。Indexが-1の場合は選択中のジョブで判定。JobDataが直接設定されている場合はバインドされたJobDataで判定")] UNIT_IS_JOBMASTER = 428, // 0x000001AC
      [Token(Token = "0x400318E"), GameParameter.UsesIndex, GameParameter.ParameterDesc("ユニット覚醒レベル"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.AlwaysUpdate] UNIT_NEXTAWAKE = 429, // 0x000001AD
      [Token(Token = "0x400318F"), GameParameter.ParameterDesc("操作時間が延長された際に表示する秒数")] MULTIPLAY_ADD_INPUTTIME = 430, // 0x000001AE
      [Token(Token = "0x4003190"), GameParameter.ParameterDesc("ユニットの限界突破最大値に達している場合にIndex:0で非表示。Index:1で表示。"), GameParameter.UsesIndex, GameParameter.AlwaysUpdate] UNIT_IS_AWAKEMAX = 431, // 0x000001AF
      [Token(Token = "0x4003191"), GameParameter.ParameterDesc("コンフィグでオートプレイ選択時場合にIndex:0で表示。Index:1で非表示。"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex] CONFIG_IS_AUTOPLAY = 432, // 0x000001B0
      [Token(Token = "0x4003192"), GameParameter.ParameterDesc("フレンドがお気に入りなら表示(0)/非表示(1)"), GameParameter.UsesIndex, GameParameter.AlwaysUpdate] FRIEND_ISFAVORITE = 433, // 0x000001B1
      [Token(Token = "0x4003193"), GameParameter.UsesIndex, GameParameter.ParameterDesc("キャラクタークエスト出撃条件(0)改行表記/(1)一行表記")] QUEST_CHARACTER_ENTRYCONDITION = 434, // 0x000001B2
      [Token(Token = "0x4003194"), GameParameter.UsesIndex, GameParameter.ParameterDesc("キャラクタークエスト出撃条件が設定されている場合に表示(0)/非表示(1)"), GameParameter.AlwaysUpdate] QUEST_CHARACTER_IS_ENTRYCONDITION = 435, // 0x000001B3
      [Token(Token = "0x4003195"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("キャラクタークエスト出撃条件のタイトル表示")] QUEST_CHARACTER_CONDITIONATTENTION = 436, // 0x000001B4
      [Token(Token = "0x4003196"), GameParameter.ParameterDesc("復帰したプレイヤーINDEX")] MULTIPLAY_RESUME_PLAYER_INDEX = 437, // 0x000001B5
      [Token(Token = "0x4003197"), GameParameter.ParameterDesc("復帰したプレイヤーがホストか？")] MULTIPLAY_RESUME_PLAYER_IS_HOST = 438, // 0x000001B6
      [Token(Token = "0x4003198"), GameParameter.ParameterDesc("復帰したが、他プレイヤーがいない")] MULTIPLAY_RESUME_BUT_NOT_PLAYER = 439, // 0x000001B7
      [Token(Token = "0x4003199"), GameParameter.ParameterDesc("ショップごとに保持数を表示するイベントコイン")] EVENTCOIN_SHOPTYPEICON = 440, // 0x000001B8
      [Token(Token = "0x400319A"), GameParameter.ParameterDesc("イベントコイン一覧のアイテム名")] EVENTCOIN_ITEMNAME = 441, // 0x000001B9
      [Token(Token = "0x400319B"), GameParameter.ParameterDesc("イベントコイン一覧の説明")] EVENTCOIN_MESSAGE = 442, // 0x000001BA
      [Token(Token = "0x400319C"), GameParameter.ParameterDesc("イベントコイン一覧の所持数")] EVENTCOIN_POSSESSION = 443, // 0x000001BB
      [Token(Token = "0x400319D"), GameParameter.ParameterDesc("ショップアイテムのイベントコイン別アイコン")] EVENTCOIN_PRICEICON = 444, // 0x000001BC
      [Token(Token = "0x400319E"), GameParameter.ParameterDesc("イベントショップアイテムの残り購入可能数を取得")] SHOP_EVENT_ITEM_BUYAMOUNT = 445, // 0x000001BD
      [Token(Token = "0x400319F"), GameParameter.ParameterDesc("イベント終了までの時間")] TROPHY_REMAININGTIME = 446, // 0x000001BE
      [Token(Token = "0x40031A0"), GameParameter.UsesIndex, GameParameter.ParameterDesc("お客様コードのみを表示")] GLOBAL_PLAYER_OKYAKUSAMACODE2 = 447, // 0x000001BF
      [Token(Token = "0x40031A1"), GameParameter.ParameterDesc("対戦相手のユニット"), GameParameter.InstanceTypes(typeof (GameParameter.VersusPlayerInstanceType))] VERSUS_UNIT_IMAGE = 448, // 0x000001C0
      [Token(Token = "0x40031A2"), GameParameter.InstanceTypes(typeof (GameParameter.VersusPlayerInstanceType)), GameParameter.ParameterDesc("対戦相手の名前")] VERSUS_PLAYER_NAME = 449, // 0x000001C1
      [Token(Token = "0x40031A3"), GameParameter.ParameterDesc("対戦相手のレベル"), GameParameter.InstanceTypes(typeof (GameParameter.VersusPlayerInstanceType))] VERSUS_PLAYER_LEVEL = 450, // 0x000001C2
      [Token(Token = "0x40031A4"), GameParameter.ParameterDesc("対戦相手の総合攻撃力"), GameParameter.InstanceTypes(typeof (GameParameter.VersusPlayerInstanceType))] VERSUS_PLAYER_TOTALATK = 451, // 0x000001C3
      [Token(Token = "0x40031A5"), GameParameter.ParameterDesc("対戦結果"), GameParameter.InstanceTypes(typeof (BattleCore.QuestResult))] VERSUS_RESULT = 452, // 0x000001C4
      [Token(Token = "0x40031A6"), GameParameter.ParameterDesc("対戦ランク表示")] VERSUS_RANK = 453, // 0x000001C5
      [Token(Token = "0x40031A7"), GameParameter.ParameterDesc("現在のランクポイントを表示")] VERSUS_RANK_POINT = 454, // 0x000001C6
      [Token(Token = "0x40031A8"), GameParameter.ParameterDesc("ランクアップまでのポイントを表示")] VERSUS_RANK_NEXT_POINT = 455, // 0x000001C7
      [Token(Token = "0x40031A9"), GameParameter.ParameterDesc("現在のランクのアイコン")] VERSUS_RANK_ICON = 456, // 0x000001C8
      [Token(Token = "0x40031AA"), GameParameter.ParameterDesc("現在のランクのインデックス")] VERSUS_RANK_ICON_INDEX = 457, // 0x000001C9
      [Token(Token = "0x40031AB"), GameParameter.ParameterDesc("部屋内プレイヤーのランクのアイコン")] VERSUS_ROOMPLAYER_RANK_ICON = 458, // 0x000001CA
      [Token(Token = "0x40031AC"), GameParameter.ParameterDesc("部屋内プレイヤーのランクのインデックス")] VERSUS_ROOMPLAYER_RANK_ICON_INDEX = 459, // 0x000001CB
      [Token(Token = "0x40031AD"), GameParameter.ParameterDesc("対戦マップのサムネイル")] VERSUS_MAP_THUMNAIL = 460, // 0x000001CC
      [Token(Token = "0x40031AE"), GameParameter.ParameterDesc("マップ選択中のサムネイル")] VERSUS_MAP_THUMNAIL2 = 461, // 0x000001CD
      [Token(Token = "0x40031AF"), GameParameter.ParameterDesc("マップ選択中のマップ名")] VERSUS_MAP_NAME = 462, // 0x000001CE
      [Token(Token = "0x40031B0"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("マップが選択されていれば表示")] VERSUS_MAP_SELECT = 463, // 0x000001CF
      [Token(Token = "0x40031B1"), GameParameter.ParameterDesc("所有アリーナコイン")] SHOP_ARENA_COIN = 464, // 0x000001D0
      [Token(Token = "0x40031B2"), GameParameter.ParameterDesc("所有マルチコイン")] SHOP_MULTI_COIN = 465, // 0x000001D1
      [Token(Token = "0x40031B3"), GameParameter.ParameterDesc("プレイヤーの所持コイン (共通無償幻晶石)")] GLOBAL_PLAYER_COINCOM = 466, // 0x000001D2
      [Token(Token = "0x40031B4"), GameParameter.ParameterDesc("プレイヤーの所持コイン (無償幻晶石　共通＆固有)")] GLOBAL_PLAYER_FREECOINSET = 467, // 0x000001D3
      [Token(Token = "0x40031B5"), GameParameter.UsesIndex, GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニット覚醒レベル2"), GameParameter.AlwaysUpdate] UNIT_AWAKE2 = 468, // 0x000001D4
      [Token(Token = "0x40031B6"), GameParameter.ParameterDesc("プロダクト個数Index: 0:トータル 1:無償 2:有償"), GameParameter.UsesIndex] PRODUCT_COINNUM = 469, // 0x000001D5
      [Token(Token = "0x40031B7"), GameParameter.ParameterDesc("アーティファクトの錬成可能数")] ARTIFACT_DRILLING_COUNT = 470, // 0x000001D6
      [Token(Token = "0x40031B8"), GameParameter.ParameterDesc("アーティファクトの錬成限界数が最大値なら表示")] ARTIFACT_DRILLING_MAXDRAW = 471, // 0x000001D7
      [Token(Token = "0x40031B9"), GameParameter.ParameterDesc("アーティファクトの錬成限界数が最大値でないなら表示")] ARTIFACT_DRILLING_NOTMAXDRAW = 472, // 0x000001D8
      [Token(Token = "0x40031BA"), GameParameter.ParameterDesc("BuycoinProductで指定しているタイトル名")] PRODUCT_BUYCOINNAME = 473, // 0x000001D9
      [Token(Token = "0x40031BB"), GameParameter.ParameterDesc("BuycoinProductで指定している説明")] PRODUCT_BUYCOINDESC = 474, // 0x000001DA
      [Token(Token = "0x40031BC"), GameParameter.AlwaysUpdate, GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの状態異常【補助禁止】")] UNIT_STATE_CONDITION_DISABLESUPPORT = 475, // 0x000001DB
      [Token(Token = "0x40031BD"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("ユニットの状態異常【爆弾】")] UNIT_STATE_CONDITION_BOMB = 476, // 0x000001DC
      [Token(Token = "0x40031BE"), GameParameter.ParameterDesc("ユニットの状態異常【スリップ】"), GameParameter.AlwaysUpdate, GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_STATE_CONDITION_SLIP = 477, // 0x000001DD
      [Token(Token = "0x40031BF"), GameParameter.ParameterDesc("ユニットの状態異常【凝固】"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.AlwaysUpdate] UNIT_STATE_CONDITION_FREEZE = 478, // 0x000001DE
      [Token(Token = "0x40031C0"), GameParameter.ParameterDesc("Buycoinステップアップの表示")] PRODUCT_BUYCOINSTEPUPACTIVE = 479, // 0x000001DF
      [Token(Token = "0x40031C1"), GameParameter.ParameterDesc("Buycoinステップアップの数値")] PRODUCT_BUYCOINSTEPUPCOUNT = 480, // 0x000001E0
      [Token(Token = "0x40031C2"), GameParameter.ParameterDesc("初回購入キャンペーンの残購入回数")] PRODUCT_CAMPAIGN_REMAIN = 481, // 0x000001E1
      [Token(Token = "0x40031C3"), GameParameter.ParameterDesc("ユニットの状態異常【ダウン】"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.AlwaysUpdate] UNIT_STATE_CONDITION_DOWN = 482, // 0x000001E2
      [Token(Token = "0x40031C4"), GameParameter.ParameterDesc("ユニットの初期MP"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_STARTMP = 483, // 0x000001E3
      [Token(Token = "0x40031C5"), GameParameter.ParameterDesc("ユニット所持アイコン"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_HAVEICON = 484, // 0x000001E4
      [Token(Token = "0x40031C6"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("覚醒+HP")] UNIT_STATUSAWAKEHP = 485, // 0x000001E5
      [Token(Token = "0x40031C7")] VS_ST = 999, // 0x000003E7
      [Token(Token = "0x40031C8"), GameParameter.ParameterDesc("対戦の報酬タイプ")] VS_TOWER_REWARD_NAME = 1000, // 0x000003E8
      [Token(Token = "0x40031C9"), GameParameter.ParameterDesc("シーズン報酬受け取り可能か？")] VS_TOWER_SEASON_RECEIPT = 1001, // 0x000003E9
      [Token(Token = "0x40031CA"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("PvPコインの枚数")] VS_COIN = 1002, // 0x000003EA
      [Token(Token = "0x40031CB"), GameParameter.ParameterDesc("フリーマッチでのpvpコイン受け取り可能枚数"), GameParameter.AlwaysUpdate] VS_REMAIN_COIN = 1003, // 0x000003EB
      [Token(Token = "0x40031CC"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("タワーマッチ開催中か"), GameParameter.UsesIndex] VS_OPEN_TOWERMATCH = 1004, // 0x000003EC
      [Token(Token = "0x40031CD"), GameParameter.ParameterDesc("対戦の種類を表示"), GameParameter.AlwaysUpdate] VS_QUEST_CATEGORY = 1005, // 0x000003ED
      [Token(Token = "0x40031CE"), GameParameter.ParameterDesc("タワーマッチで連勝した際のボーナス表示"), GameParameter.AlwaysUpdate] VS_TOWER_WINBONUS = 1006, // 0x000003EE
      [Token(Token = "0x40031CF"), GameParameter.UsesIndex, GameParameter.ParameterDesc("観戦時の表示・非表示対応"), GameParameter.AlwaysUpdate] VS_AUDIENCE_DISPLAY = 1007, // 0x000003EF
      [Token(Token = "0x40031D0"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex, GameParameter.ParameterDesc("Index == 0:1P勝利 / Index == 1:2P勝利 時に表示する")] VS_AUDIENCE_WIN_PLAYER = 1008, // 0x000003F0
      [Token(Token = "0x40031D1"), GameParameter.ParameterDesc("観戦時のときだけ表示する"), GameParameter.AlwaysUpdate] VS_AUDIENCE_ONLY_DISPLAY = 1009, // 0x000003F1
      [Token(Token = "0x40031D2"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("観戦している部屋の種類")] VS_AUDIENCE_TYPE = 1010, // 0x000003F2
      [Token(Token = "0x40031D3"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("現在の階層")] VS_TOWER_FLOOR = 1011, // 0x000003F3
      [Token(Token = "0x40031D4"), GameParameter.ParameterDesc("タワーマッチのときだけ表示する"), GameParameter.AlwaysUpdate] VS_TOWER_ONLY_DISPLAY = 1012, // 0x000003F4
      [Token(Token = "0x40031D5"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("観戦者数")] VS_AUDIENCE_NUM = 1013, // 0x000003F5
      [Token(Token = "0x40031D6"), GameParameter.ParameterDesc("CPU対戦の難易度"), GameParameter.AlwaysUpdate] VS_CPU_DIFFICULTY = 1014, // 0x000003F6
      [Token(Token = "0x40031D7"), GameParameter.ParameterDesc("CPU対戦の名前"), GameParameter.AlwaysUpdate] VS_CPU_NAME = 1015, // 0x000003F7
      [Token(Token = "0x40031D8"), GameParameter.ParameterDesc("CPU対戦のレベル"), GameParameter.AlwaysUpdate] VS_CPU_LV = 1016, // 0x000003F8
      [Token(Token = "0x40031D9"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("CPU対戦の攻撃力")] VS_CPU_TOTALATK = 1017, // 0x000003F9
      [Token(Token = "0x40031DA"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("タワーマッチの同一ユニット判定があるか？")] VS_TOWER_SAMEUNIT = 1018, // 0x000003FA
      [Token(Token = "0x40031DB")] VS_ED = 1098, // 0x0000044A
      [Token(Token = "0x40031DC"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("武具コンディション")] ARTIFACT_ST = 1099, // 0x0000044B
      [Token(Token = "0x40031DD"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("武具コンディション")] ARTIFACT_EVOLUTION_COND = 1100, // 0x0000044C
      [Token(Token = "0x40031DE"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex, GameParameter.ParameterDesc("武具がお気に入りなら表示(0)/非表示(1)")] ARTIFACT_ISFAVORITE = 1101, // 0x0000044D
      [Token(Token = "0x40031DF"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("武具の進化後の★の数")] ARTIFACT_EVOLUTION_RARITY = 1102, // 0x0000044E
      [Token(Token = "0x40031E0"), GameParameter.InstanceTypes(typeof (GameParameter.ArtifactInstanceTypes)), GameParameter.UsesIndex, GameParameter.ParameterDesc("武具アイコン")] ARTIFACT_ICON = 1103, // 0x0000044F
      [Token(Token = "0x40031E1"), GameParameter.InstanceTypes(typeof (GameParameter.ArtifactInstanceTypes)), GameParameter.UsesIndex, GameParameter.ParameterDesc("武具の種類にあわせたフレームをImageに設定します。")] ARTIFACT_FRAME = 1104, // 0x00000450
      [Token(Token = "0x40031E2"), GameParameter.UsesIndex, GameParameter.InstanceTypes(typeof (GameParameter.ArtifactInstanceTypes)), GameParameter.ParameterDesc("武具の個数")] ARTIFACT_AMOUNT = 1105, // 0x00000451
      [Token(Token = "0x40031E3"), GameParameter.ParameterDesc("武具のオススメバッジ"), GameParameter.AlwaysUpdate] ARTIFACT_RECOMMEND_BADGE = 1106, // 0x00000452
      [Token(Token = "0x40031E4"), GameParameter.ParameterDesc("武具にひらめきスキル合成ボーナスがある場合に表示(0)/非表示(1)"), GameParameter.AlwaysUpdate] ARTIFACT_INSPSKILL_BONUS = 1107, // 0x00000453
      [Token(Token = "0x40031E5"), GameParameter.ParameterDesc("武具にひらめきスキル合成ボーナスの値"), GameParameter.AlwaysUpdate] ARTIFACT_INSPSKILL_BONUS_VALUE = 1108, // 0x00000454
      [Token(Token = "0x40031E6"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("武具のフレーバーテキスト")] ARTIFACT_FLAVOR = 1109, // 0x00000455
      [Token(Token = "0x40031E7")] ARTIFACT_ED = 1198, // 0x000004AE
      [Token(Token = "0x40031E8")] QUEST_UI_ST = 1199, // 0x000004AF
      [Token(Token = "0x40031E9"), GameParameter.ParameterDesc("クエストコンティニュー不可が設定されている場合に表示(0)/非表示(1)"), GameParameter.UsesIndex, GameParameter.AlwaysUpdate] QUEST_IS_MAP_NO_CONTINUE = 1200, // 0x000004B0
      [Token(Token = "0x40031EA"), GameParameter.UsesIndex, GameParameter.ParameterDesc("クエストダメージ制限が設定されている場合に表示(0)/非表示(1)"), GameParameter.AlwaysUpdate] QUEST_IS_MAP_DAMAGE_LIMIT = 1201, // 0x000004B1
      [Token(Token = "0x40031EB"), GameParameter.UsesIndex, GameParameter.ParameterDesc("クエスト情報の詳細テキスト Loc/japanese/quest_info.txt参照"), GameParameter.AlwaysUpdate] QUEST_UI_DETAIL_INFO = 1202, // 0x000004B2
      [Token(Token = "0x40031EC"), GameParameter.ParameterDesc("クエスト出撃条件でチームが固定されていて、かつユニットが設定されている場合に表示(0)/非表示(1)"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex] QUEST_IS_UNIT_ENTRYCONDITION_FORCE_AVAILABLEUNIT = 1203, // 0x000004B3
      [Token(Token = "0x40031ED"), GameParameter.ParameterDesc("クエスト出撃条件で出撃ユニットが制限されていた場合に表示"), GameParameter.AlwaysUpdate] QUEST_IS_UNIT_ENTRYCONDITION_LIMIT = 1204, // 0x000004B4
      [Token(Token = "0x40031EE"), GameParameter.ParameterDesc("クエスト出撃条件で出撃ユニットが固定されていた場合に表示"), GameParameter.AlwaysUpdate] QUEST_IS_UNIT_ENTRYCONDITION_FORCE = 1205, // 0x000004B5
      [Token(Token = "0x40031EF"), GameParameter.ParameterDesc("クエストをクリアしていた場合にinteractable=true(0)/false(1)"), GameParameter.UsesIndex, GameParameter.AlwaysUpdate] QUEST_IS_CLEARD_INTERACTABLE = 1206, // 0x000004B6
      [Token(Token = "0x40031F0"), GameParameter.ParameterDesc("クエストユニット交代が許可されている場合に表示(0)/非表示(1)"), GameParameter.UsesIndex, GameParameter.AlwaysUpdate] QUEST_IS_UNIT_CHANGE = 1207, // 0x000004B7
      [Token(Token = "0x40031F1"), GameParameter.ParameterDesc("ユニット未所持による出撃不可か？:表示(0)/非表示(1)"), GameParameter.UsesIndex, GameParameter.AlwaysUpdate] QUEST_HAVE_UNIT_LOCK = 1208, // 0x000004B8
      [Token(Token = "0x40031F2"), GameParameter.ParameterDesc("ストーリーEXの挑戦回数に制限が設定されているなら表示")] QUEST_UI_STORYEX_RESTCOUNT_ACTIVE = 1209, // 0x000004B9
      [Token(Token = "0x40031F3"), GameParameter.ParameterDesc("ストーリーEXの残り挑戦回数")] QUEST_UI_STORYEX_RESTCOUNT = 1210, // 0x000004BA
      [Token(Token = "0x40031F4"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("未クリアのキャラクエがあれば表示")] QUEST_UI_CHARACTER_QUEST_NOT_CLEARED_EXIST = 1211, // 0x000004BB
      [Token(Token = "0x40031F5"), GameParameter.ParameterDesc("キャラクエがクリア済みであれば表示"), GameParameter.AlwaysUpdate] QUEST_UI_CHARACTER_QUEST_ALL_CLEARED = 1212, // 0x000004BC
      [Token(Token = "0x40031F6"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("キャラクエがあれば表示")] QUEST_UI_HAS_CHARACTER_QUEST_ACTIVE = 1213, // 0x000004BD
      [Token(Token = "0x40031F7")] QUEST_IS_ED = 1298, // 0x00000512
      [Token(Token = "0x40031F8")] TRICK_ST = 1299, // 0x00000513
      [Token(Token = "0x40031F9"), GameParameter.ParameterDesc("特殊パネルの名称")] TRICK_NAME = 1300, // 0x00000514
      [Token(Token = "0x40031FA"), GameParameter.ParameterDesc("特殊パネルの説明")] TRICK_DESC = 1301, // 0x00000515
      [Token(Token = "0x40031FB"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("特殊パネルUIアイコン")] TRICK_UI_ICON = 1302, // 0x00000516
      [Token(Token = "0x40031FC")] TRICK_ED = 1398, // 0x00000576
      [Token(Token = "0x40031FD")] BATTLE_UI_ST = 1399, // 0x00000577
      [Token(Token = "0x40031FE"), GameParameter.ParameterDesc("オーダーユニットが詠唱中か？")] BATTLE_UI_IMG_IS_CAST_ORDER = 1400, // 0x00000578
      [Token(Token = "0x40031FF"), GameParameter.ParameterDesc("スキルの使用回数")] SKILL_USE_COUNT = 1401, // 0x00000579
      [Token(Token = "0x4003200"), GameParameter.EnumParameterDesc("スキル属性にあわせてImageArrayを切り替えます。(属性がない場合は非表示)", typeof (EElement)), GameParameter.AlwaysUpdate, GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] SKILL_ELEMENT = 1402, // 0x0000057A
      [Token(Token = "0x4003201"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.AlwaysUpdate, GameParameter.EnumParameterDesc("スキル攻撃詳細区分にあわせてImageArrayを切り替えます。(攻撃詳細区分がない場合は非表示)", typeof (AttackDetailTypes))] SKILL_ATTACK_DETAIL = 1403, // 0x0000057B
      [Token(Token = "0x4003202"), GameParameter.EnumParameterDesc("スキル攻撃タイプにあわせてImageArrayを切り替えます。(攻撃タイプがない場合は非表示)", typeof (AttackTypes)), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.AlwaysUpdate] SKILL_ATTACK_TYPE = 1404, // 0x0000057C
      [Token(Token = "0x4003203"), GameParameter.ParameterDesc("天候が発動していれば表示(0)/非表示(1)")] BATTLE_UI_WTH_IS_ENABLE = 1405, // 0x0000057D
      [Token(Token = "0x4003204"), GameParameter.ParameterDesc("天候名を表示")] BATTLE_UI_WTH_NAME = 1406, // 0x0000057E
      [Token(Token = "0x4003205"), GameParameter.ParameterDesc("天候アイコンを表示")] BATTLE_UI_WTH_ICON = 1407, // 0x0000057F
      [Token(Token = "0x4003206"), GameParameter.ParameterDesc("変身を加味したユニットのHP"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_DTU_HP = 1408, // 0x00000580
      [Token(Token = "0x4003207"), GameParameter.ParameterDesc("変身を加味したユニットのMP"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_DTU_MP = 1409, // 0x00000581
      [Token(Token = "0x4003208"), GameParameter.ParameterDesc("スキルの詠唱速度")] SKILL_CASTSPEED = 1410, // 0x00000582
      [Token(Token = "0x4003209"), GameParameter.ParameterDesc("スキルの詠唱速度設定があるなら表示")] SKILL_CASTSPEED_ACTIVE = 1411, // 0x00000583
      [Token(Token = "0x400320A")] BATTLE_UI_ED = 1498, // 0x000005DA
      [Token(Token = "0x400320B")] UNIT_EXTRA_PARAM_ST = 1499, // 0x000005DB
      [Token(Token = "0x400320C"), GameParameter.ParameterDesc("ユニットの移動力"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_EXTRA_PARAM_MOVE = 1500, // 0x000005DC
      [Token(Token = "0x400320D"), GameParameter.ParameterDesc("ユニットのジャンプ力"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes))] UNIT_EXTRA_PARAM_JUMP = 1501, // 0x000005DD
      [Token(Token = "0x400320E"), GameParameter.ParameterDesc("ユニット小アイコン表示")] UNITPARAM_ICON_SMALL = 1502, // 0x000005DE
      [Token(Token = "0x400320F"), GameParameter.ParameterDesc("ユニット中アイコン表示")] UNITPARAM_ICON_MEDIUM = 1503, // 0x000005DF
      [Token(Token = "0x4003210"), GameParameter.ParameterDesc("ユニット一枚絵表示")] UNITPARAM_IMAGE = 1504, // 0x000005E0
      [Token(Token = "0x4003211"), GameParameter.ParameterDesc("ユニット目アイコン表示")] UNITPARAM_EYE_IMAGE = 1505, // 0x000005E1
      [Token(Token = "0x4003212")] UNIT_EXTRA_PARAM_ED = 1598, // 0x0000063E
      [Token(Token = "0x4003213")] MULTI_UI_ST = 1599, // 0x0000063F
      [Token(Token = "0x4003214"), GameParameter.ParameterDesc("マルチのユニットレベル制限")] MULTI_UI_ROOM_LIMIT_UNITLV = 1600, // 0x00000640
      [Token(Token = "0x4003215"), GameParameter.ParameterDesc("クリアの有無")] MULTI_UI_ROOM_LIMIT_CLEAR = 1601, // 0x00000641
      [Token(Token = "0x4003216"), GameParameter.UsesIndex, GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("現在の操作プレイヤー名を表示 [0]:切断時グレー表示 [1]:思考中追加 [2]～のターン追加")] MULTI_UI_CURRENT_PLAYER_NAME = 1602, // 0x00000642
      [Token(Token = "0x4003217"), GameParameter.ParameterDesc("マルチタワーでの総攻撃力")] MULTI_TOWER_UI_PARTY_TOTALATK = 1603, // 0x00000643
      [Token(Token = "0x4003218"), GameParameter.UsesIndex, GameParameter.InstanceTypes(typeof (PhotonPlayerData.PlayerState)), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("オーナーの状態")] MULTI_OWNER_STATE = 1604, // 0x00000644
      [Token(Token = "0x4003219"), GameParameter.ParameterDesc("マルチタワー階層")] MULTI_TOWER_FLOOR = 1605, // 0x00000645
      [Token(Token = "0x400321A"), GameParameter.ParameterDesc("リーダースキル有効なクエストか？")] MULTI_QUEST_IS_LEADERSKILL = 1606, // 0x00000646
      [Token(Token = "0x400321B"), GameParameter.ParameterDesc("マルチ部屋リストの階層")] MULTI_TOWER_ROOM_LIST_FLOOR = 1607, // 0x00000647
      [Token(Token = "0x400321C"), GameParameter.ParameterDesc("マルチ部屋リストのクリア済みか")] MULTI_TOWER_ROOM_LIST_ISCLEAR = 1608, // 0x00000648
      [Token(Token = "0x400321D"), GameParameter.ParameterDesc("マルチタワーのスキップができる状態であれば表示(0)/非表示(1)")] MULTI_TOWER_IS_CAN_SKIP = 1609, // 0x00000649
      [Token(Token = "0x400321E"), GameParameter.ParameterDesc("現在の部屋の倍速設定")] MULTI_CURRENT_ROOM_SPEED = 1610, // 0x0000064A
      [Token(Token = "0x400321F"), GameParameter.ParameterDesc("リストの部屋の倍速設定")] MULTI_ROOM_LIST_SPEED = 1611, // 0x0000064B
      [Token(Token = "0x4003220"), GameParameter.ParameterDesc("現在の部屋のオート許可設定")] MULTI_CURRENT_ROOM_AUTOPERMISSION = 1612, // 0x0000064C
      [Token(Token = "0x4003221"), GameParameter.ParameterDesc("リストの部屋のオート許可設定")] MULTI_ROOM_LIST_AUTOPERMISSION = 1613, // 0x0000064D
      [Token(Token = "0x4003222"), GameParameter.ParameterDesc("キック可能なら表示（プレイヤーがホストかつ、プレイヤーが埋まっている枠）"), GameParameter.AlwaysUpdate] MULTI_PLAYER_ENABLE_KICK = 1614, // 0x0000064E
      [Token(Token = "0x4003223"), GameParameter.UsesIndex, GameParameter.ParameterDesc("マルチフレンドAI設定ボタン（プレイヤーがホストかつ、0:空き枠、1:フレンドAIの枠で表示）"), GameParameter.AlwaysUpdate] MULTI_PLAYER_FRIENDAI = 1615, // 0x0000064F
      [Token(Token = "0x4003224"), GameParameter.ParameterDesc("マルチのオート設定状況表示"), GameParameter.AlwaysUpdate] MULTI_PLAYER_AUTOSETTING = 1616, // 0x00000650
      [Token(Token = "0x4003225"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("マルチフレンドAIなら表示")] MULTI_PLAYER_IS_FRIENDAI = 1617, // 0x00000651
      [Token(Token = "0x4003226"), GameParameter.ParameterDesc("行動順のプレイヤーがオート操作のとき表示"), GameParameter.AlwaysUpdate] MULTI_CURRENT_PLAYER_IS_AUTO = 1618, // 0x00000652
      [Token(Token = "0x4003227"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("行動順のプレイヤーがサポートAIのとき表示")] MULTI_CURRENT_PLAYER_IS_SUPPORTAI = 1619, // 0x00000653
      [Token(Token = "0x4003228"), GameParameter.ParameterDesc("マルチタワーのソロ出撃可不可")] MULTI_TOWER_CONDITION_NOT_SORO = 1620, // 0x00000654
      [Token(Token = "0x4003229"), GameParameter.ParameterDesc("マルチタワー専用の総戦闘力表示")] MULTI_TOWER_TOTALCOMBATPOWER = 1621, // 0x00000655
      [Token(Token = "0x400322A")] MULTI_UI_ED = 1698, // 0x000006A2
      [Token(Token = "0x400322B")] QUEST_BONUSOBJECTIVE_ST = 1699, // 0x000006A3
      [Token(Token = "0x400322C"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes)), GameParameter.EnumParameterDesc("プレイ中クエストのボーナス条件の達成状態にあわせてImageArrayを切り替えます(未達成/達成/全達成)。インデックスでボーナス条件の番号を指定してください。", typeof (QuestBonusObjectiveState))] QUEST_BONUSOBJECTIVE_STAR = 1700, // 0x000006A4
      [Token(Token = "0x400322D"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes)), GameParameter.ParameterDesc("クエストミッションの達成個数を表示します。全てのミッションを達成していた場合、テキストの色が変わります。")] QUEST_BONUSOBJECTIVE_AMOUNT = 1701, // 0x000006A5
      [Token(Token = "0x400322E"), GameParameter.ParameterDesc("クエストミッションの最大個数を表示します。"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes))] QUEST_BONUSOBJECTIVE_AMOUNTMAX = 1702, // 0x000006A6
      [Token(Token = "0x400322F"), GameParameter.UsesIndex, GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes)), GameParameter.ParameterDesc("クエストミッションの報酬の数を表示します。")] QUEST_BONUSOBJECTIVE_REWARD_NUM = 1703, // 0x000006A7
      [Token(Token = "0x4003230"), GameParameter.ParameterDesc("クエストミッションの進捗を表示するタイプのミッションならActive、表示しないタイプなら非Active"), GameParameter.UsesIndex, GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes))] QUEST_BONUSOBJECTIVE_PROGRESS_BADGE = 1704, // 0x000006A8
      [Token(Token = "0x4003231"), GameParameter.ParameterDesc("クエストミッションの進捗（現在）"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes)), GameParameter.UsesIndex] QUEST_BONUSOBJECTIVE_PROGRESS_CURRENT = 1705, // 0x000006A9
      [Token(Token = "0x4003232"), GameParameter.ParameterDesc("クエストミッションの進捗（目標値）"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes)), GameParameter.UsesIndex] QUEST_BONUSOBJECTIVE_PROGRESS_TARGET = 1706, // 0x000006AA
      [Token(Token = "0x4003233"), GameParameter.ParameterDesc("塔クエストの固定ミッションの星"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes)), GameParameter.UsesIndex] QUEST_TOWER_BONUSOBJECTIVE_FIXED_STATE = 1707, // 0x000006AB
      [Token(Token = "0x4003234"), GameParameter.ParameterDesc("塔クエストミッションの達成個数を表示します。全てのミッションを達成していた場合、テキストの色が変わります。"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes))] QUEST_TOWER_BONUSOBJECTIVE_AMOUNT = 1708, // 0x000006AC
      [Token(Token = "0x4003235"), GameParameter.ParameterDesc("塔クエストミッションの最大個数を表示します。"), GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes))] QUEST_TOWER_BONUSOBJECTIVE_AMOUNTMAX = 1709, // 0x000006AD
      [Token(Token = "0x4003236"), GameParameter.ParameterDesc("クエストミッションの進捗（現在）\n▼色変更あり\n　達成可能：緑\n　達成不可：赤\n　達成済み：白"), GameParameter.UsesIndex, GameParameter.InstanceTypes(typeof (GameParameter.QuestInstanceTypes))] QUEST_TOWER_BONUSOBJECTIVE_PROGRESS_COLOR = 1710, // 0x000006AE
      [Token(Token = "0x4003237")] QUEST_BONUSOBJECTIVE_ED = 1798, // 0x00000706
      [Token(Token = "0x4003238")] ME_UI_ST = 1799, // 0x00000707
      [Token(Token = "0x4003239"), GameParameter.ParameterDesc("スキルのマップ(地形)効果説明")] ME_UI_SKILL_DESC = 1800, // 0x00000708
      [Token(Token = "0x400323A"), GameParameter.ParameterDesc("マップ(地形)効果名")] ME_UI_NAME = 1801, // 0x00000709
      [Token(Token = "0x400323B"), GameParameter.ParameterDesc("ジョブ特効説明")] JOB_DESC_CH = 1802, // 0x0000070A
      [Token(Token = "0x400323C"), GameParameter.ParameterDesc("ジョブ特効説明が設定されていれば表示(0)")] IS_JOB_DESC_CH = 1803, // 0x0000070B
      [Token(Token = "0x400323D"), GameParameter.ParameterDesc("ジョブその他の効果説明")] JOB_DESC_OT = 1804, // 0x0000070C
      [Token(Token = "0x400323E"), GameParameter.ParameterDesc("ジョブその他の効果説明が設定されていれば表示(0)")] IS_JOB_DESC_OT = 1805, // 0x0000070D
      [Token(Token = "0x400323F"), GameParameter.InstanceTypes(typeof (GameParameter.UnitInstanceTypes)), GameParameter.ParameterDesc("ユニットの現ジョブのMediumアイコン。UNIT_JOBICON2に参照不具合があるため新設")] UNIT_JOBICON2_BUGFIX = 1806, // 0x0000070E
      [Token(Token = "0x4003240")] ME_UI_ED = 1898, // 0x0000076A
      [Token(Token = "0x4003241")] FIRST_FRIEND_ST = 1899, // 0x0000076B
      [Token(Token = "0x4003242"), GameParameter.ParameterDesc("初フレンド成立人数上限")] FIRST_FRIEND_MAX = 1900, // 0x0000076C
      [Token(Token = "0x4003243"), GameParameter.ParameterDesc("初フレンド成立人数")] FIRST_FRIEND_COUNT = 1901, // 0x0000076D
      [Token(Token = "0x4003244")] FIRST_FRIEND_ED = 1998, // 0x000007CE
      [Token(Token = "0x4003245")] CHALLENGEMISSION_ST = 1999, // 0x000007CF
      [Token(Token = "0x4003246"), GameParameter.ParameterDesc("カテゴリ名からヘルプ画像を表示")] CHALLENGEMISSION_IMG_HELP = 2000, // 0x000007D0
      [Token(Token = "0x4003247"), GameParameter.ParameterDesc("カテゴリ名からタブ画像を表示")] CHALLENGEMISSION_IMG_BUTTON = 2001, // 0x000007D1
      [Token(Token = "0x4003248"), GameParameter.ParameterDesc("トロフィー名から報酬画像を表示")] CHALLENGEMISSION_IMG_REWARD = 2002, // 0x000007D2
      [Token(Token = "0x4003249")] CHALLENGEMISSION_ED = 2098, // 0x00000832
      [Token(Token = "0x400324A")] UNITPARAM_EXTRA_ST = 2099, // 0x00000833
      [Token(Token = "0x400324B"), GameParameter.ParameterDesc("ユニットパラメーターの錬成可能終了日時(Y/m/d H:i)")] UNITPARAM_EXTRA_UNLOCKLIMIT = 2100, // 0x00000834
      [Token(Token = "0x400324C"), GameParameter.ParameterDesc("訓練対戦のの総戦闘力"), GameParameter.InstanceTypes(typeof (GameParameter.VersusPlayerInstanceType))] VERSUS_COM_TOTALSTATUS = 2101, // 0x00000835
      [Token(Token = "0x400324D"), GameParameter.ParameterDesc("運営指定戦のリーダーユニット画像"), GameParameter.InstanceTypes(typeof (GameParameter.VersusPlayerInstanceType))] VERSUS_DRAFT_IMAGE = 2102, // 0x00000836
      [Token(Token = "0x400324E"), GameParameter.ParameterDesc("運営指定戦のパーティユニットアイコン"), GameParameter.InstanceTypes(typeof (GameParameter.VersusDraftSlot))] VERSUS_DRAFT_PARTY_IMAGE_ICON = 2103, // 0x00000837
      [Token(Token = "0x400324F"), GameParameter.ParameterDesc("運営指定戦で先攻/後攻でGameObjectのOn/Off切り替え"), GameParameter.InstanceTypes(typeof (GameParameter.VersusPlayerInstanceType))] VERSUS_DRAFT_TURN = 2104, // 0x00000838
      [Token(Token = "0x4003250"), GameParameter.InstanceTypes(typeof (GameParameter.VersusDraftSlot)), GameParameter.ParameterDesc("運営指定戦のパーティユニット画像")] VERSUS_DRAFT_PARTY_IMAGE = 2105, // 0x00000839
      [Token(Token = "0x4003251"), GameParameter.InstanceTypes(typeof (GameParameter.VersusPlayerInstanceType)), GameParameter.ParameterDesc("運営指定戦のパーティ総攻撃力")] VERSUS_DRAFT_PARTY_TOTALATK = 2106, // 0x0000083A
      [Token(Token = "0x4003252"), GameParameter.ParameterDesc("レンタルユニットの親密度プログレスバー")] RENTAL_UNIT_FAVORITEPOINT_BAR = 2107, // 0x0000083B
      [Token(Token = "0x4003253"), GameParameter.ParameterDesc("レンタルユニットの親密度％")] RENTAL_UNIT_FAVORITEPOINT_PERCENT = 2108, // 0x0000083C
      [Token(Token = "0x4003254"), GameParameter.ParameterDesc("レンタルユニットクエストの解放条件")] RENTAL_UNIT_UNLOCK_CONDITION = 2109, // 0x0000083D
      [Token(Token = "0x4003255"), GameParameter.ParameterDesc("レンタルユニットの親密度プログレスバー目盛り")] RENTAL_UNIT_FAVORITEPOINT_LINE = 2110, // 0x0000083E
      [Token(Token = "0x4003256"), GameParameter.ParameterDesc("ユニット欠片ショップの通貨アイコン")] UNIT_PIECE_SHOP_CURRENCY_ICON = 2111, // 0x0000083F
      [Token(Token = "0x4003257"), GameParameter.ParameterDesc("UnitTooltip用のリーダースキル切替ボタンON/OFF")] UNIT_LEADERSKILL_CHANGE_TOOLTIP_BUTTON = 2112, // 0x00000840
      [Token(Token = "0x4003258"), GameParameter.ParameterDesc("リーダースキル枠画像")] UNIT_LEADERSKILL_IMAGE = 2113, // 0x00000841
      [Token(Token = "0x4003259"), GameParameter.InstanceTypes(typeof (GameParameter.VersusPlayerInstanceType)), GameParameter.ParameterDesc("運営指定戦のパーティ総戦闘力")] VERSUS_DRAFT_PARTY_TOTALCOMBATPOWER = 2114, // 0x00000842
      [Token(Token = "0x400325A"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("UnitInventoryWindow用のリーダースキル切替ボタンON/OFF")] UNIT_LEADERSKILL_CHANGE_INVENTORY_BUTTON = 2115, // 0x00000843
      [Token(Token = "0x400325B"), GameParameter.ParameterDesc("ユニットの出身地(Assets/Resource/UnitBirthIcon/UnitInventoryInfo_BirthFlag)")] UNIT_BIRTH_ICON = 2116, // 0x00000844
      [Token(Token = "0x400325C"), GameParameter.ParameterDesc("リーダースキル詳細ボタンON/OFF(リーダースキルを所持していなければ off...念装リーダースキルも対象)"), GameParameter.AlwaysUpdate] UNIT_LEADERSKILL_DETAIL_BUTTON = 2117, // 0x00000845
      [Token(Token = "0x400325D"), GameParameter.ParameterDesc("スキルOn/Offの機能が有効なら表示、無効なら非表示"), GameParameter.AlwaysUpdate] UNIT_INVALID_SKILL_ENABLE = 2118, // 0x00000846
      [Token(Token = "0x400325E"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("ユニットが進化可能なら表示、不可能なら非表示")] UNIT_CAN_EVOLUTION_ENABLE = 2119, // 0x00000847
      [Token(Token = "0x400325F")] UNITPARAM_EXTRA_ED = 2198, // 0x00000896
      [Token(Token = "0x4003260")] UNIT_TOBIRA_ST = 2199, // 0x00000897
      [Token(Token = "0x4003261"), GameParameter.ParameterDesc("真理開眼の開放に必要なゼニー")] UNIT_TOBIRA_UNLOCK_COST = 2200, // 0x00000898
      [Token(Token = "0x4003262"), GameParameter.ParameterDesc("真理開眼の開放に必要な素材の数")] UNIT_TOBIRA_UNLOCK_REQAMOUNT = 2201, // 0x00000899
      [Token(Token = "0x4003263"), GameParameter.ParameterDesc("真理開眼の開放に必要な素材の所持数")] UNIT_TOBIRA_UNLOCK_AMOUNT = 2202, // 0x0000089A
      [Token(Token = "0x4003264"), GameParameter.ParameterDesc("真理開眼の扉の強化に必要な素材の数")] UNIT_TOBIRA_ENHANCE_REQAMOUNT = 2203, // 0x0000089B
      [Token(Token = "0x4003265"), GameParameter.ParameterDesc("真理開眼の扉の強化に必要な素材の所持数")] UNIT_TOBIRA_ENHANCE_AMOUNT = 2204, // 0x0000089C
      [Token(Token = "0x4003266"), GameParameter.UsesIndex, GameParameter.ParameterDesc("真理開眼の扉のレベルを示すアイコン表示")] UNIT_TOBIRA_LEVEL_ICON = 2205, // 0x0000089D
      [Token(Token = "0x4003267"), GameParameter.UsesIndex, GameParameter.ParameterDesc("真理開眼の扉のレベルを示すアイコン表示")] UNIT_TOBIRA_LEVEL_ICON2 = 2206, // 0x0000089E
      [Token(Token = "0x4003268"), GameParameter.ParameterDesc("真理開眼の扉を開放可能なら表示、不可能なら非表示"), GameParameter.AlwaysUpdate] UNIT_TOBIRA_CAN_UNLOCK = 2207, // 0x0000089F
      [Token(Token = "0x4003269")] UNIT_TOBIRA_ED = 2298, // 0x000008FA
      [Token(Token = "0x400326A")] ITEM_ST = 2299, // 0x000008FB
      [Token(Token = "0x400326B"), GameParameter.ParameterDesc("アイテムのレアリティ")] ITEM_RARITY = 2300, // 0x000008FC
      [Token(Token = "0x400326C"), GameParameter.ParameterDesc("アイテムのフレーバーテキスト(フレーバーが無ければ説明)")] ITEM_FLAVORORDESC = 2301, // 0x000008FD
      [Token(Token = "0x400326D"), GameParameter.ParameterDesc("任意の数をテキストにセット")] ITEM_INTTONUM = 2302, // 0x000008FE
      [Token(Token = "0x400326E"), GameParameter.ParameterDesc("期限付きアイテムの有効期限"), GameParameter.InstanceTypes(typeof (GameParameter.LimitItemInstanceType))] ITEM_USE_PERIOD = 2303, // 0x000008FF
      [Token(Token = "0x400326F")] ITEM_ED = 2398, // 0x0000095E
      [Token(Token = "0x4003270")] GLOBAL_PLAYER_RANKMATCH_ST = 2399, // 0x0000095F
      [Token(Token = "0x4003271"), GameParameter.ParameterDesc("プレイヤーのランクマッチのランキング順位")] GLOBAL_PLAYER_RANKMATCH_RANK = 2400, // 0x00000960
      [Token(Token = "0x4003272"), GameParameter.ParameterDesc("プレイヤーのランクマッチのポイント")] GLOBAL_PLAYER_RANKMATCH_SCORE_CURRENT = 2401, // 0x00000961
      [Token(Token = "0x4003273"), GameParameter.ParameterDesc("プレイヤーの次のクラスまでに必要なポイント")] GLOBAL_PLAYER_RANKMATCH_SCORE_NEXT = 2402, // 0x00000962
      [Token(Token = "0x4003274"), GameParameter.ParameterDesc("プレイヤーのランクマッチ挑戦可能回数")] GLOBAL_PLAYER_RANKMATCH_BP = 2403, // 0x00000963
      [Token(Token = "0x4003275"), GameParameter.ParameterDesc("ランクマッチのクラスアイコン")] RANKMATCH_CLASS_ICON = 2404, // 0x00000964
      [Token(Token = "0x4003276"), GameParameter.ParameterDesc("ランクマッチのクラス名")] RANKMATCH_CLASS_NAME = 2405, // 0x00000965
      [Token(Token = "0x4003277"), GameParameter.ParameterDesc("ランクマッチのクラスの枠")] RANKMATCH_CLASS_FRAME = 2406, // 0x00000966
      [Token(Token = "0x4003278"), GameParameter.ParameterDesc("プレイヤーのランクマッチのクラスと同じなら表示")] RANKMATCH_PLAYER_ISCLASS = 2407, // 0x00000967
      [Token(Token = "0x4003279"), GameParameter.ParameterDesc("プレイヤーのランクマッチの順位(3位以上なら非表示になる)")] GLOBAL_PLAYER_RANKMATCH_RANK_IMAGESET = 2408, // 0x00000968
      [Token(Token = "0x400327A"), GameParameter.ParameterDesc("プレイヤーのランクマッチの順位アイコン(4位以下なら非表示になる)")] GLOBAL_PLAYER_RANKMATCH_RANK_ICON = 2409, // 0x00000969
      [Token(Token = "0x400327B"), GameParameter.ParameterDesc("プレイヤーのランクマッチパーティの総攻撃力")] PARTY_RANKMATCHTOTALATK = 2410, // 0x0000096A
      [Token(Token = "0x400327C"), GameParameter.ParameterDesc("ランクマッチのランキングの順位(3位以上なら非表示になる)")] RANKMATCH_RANKING_RANK_IMAGESET = 2411, // 0x0000096B
      [Token(Token = "0x400327D"), GameParameter.ParameterDesc("ランクマッチのランキングの順位アイコン(4位以下なら非表示になる)")] RANKMATCH_RANKING_RANK_ICON = 2412, // 0x0000096C
      [Token(Token = "0x400327E"), GameParameter.ParameterDesc("ランクマッチのランキングのクラスアイコン")] RANKMATCH_RANKING_CLASS = 2413, // 0x0000096D
      [Token(Token = "0x400327F"), GameParameter.ParameterDesc("ランクマッチのランキングのユーザー名")] RANKMATCH_RANKING_NAME = 2414, // 0x0000096E
      [Token(Token = "0x4003280"), GameParameter.ParameterDesc("ランクマッチのランキングのユーザーランク")] RANKMATCH_RANKING_LEVEL = 2415, // 0x0000096F
      [Token(Token = "0x4003281"), GameParameter.ParameterDesc("ランクマッチのランキングのスコア")] RANKMATCH_RANKING_SCORE = 2416, // 0x00000970
      [Token(Token = "0x4003282"), GameParameter.ParameterDesc("プレイヤーのランクマッチのクラス"), GameParameter.InstanceTypes(typeof (GameParameter.RankMatchPlayer))] GLOBAL_PLAYER_RANKMATCH_CLASS = 2417, // 0x00000971
      [Token(Token = "0x4003283"), GameParameter.ParameterDesc("ランクマッチのランキングの順位(3位以上なら非表示になる)")] RANKMATCH_RANKING_RANKREWARD_IMAGESET_BEGIN = 2418, // 0x00000972
      [Token(Token = "0x4003284")] RANKMATCH_RANKING_RANKREWARD_IMAGESET_END = 2419, // 0x00000973
      [Token(Token = "0x4003285"), GameParameter.ParameterDesc("ランクマッチのランキングの順位アイコン(4位以下なら非表示になる)")] RANKMATCH_RANKING_RANKREWARD_ICON = 2420, // 0x00000974
      [Token(Token = "0x4003286"), GameParameter.ParameterDesc("ランクマッチの戦績の勝敗")] RANKMATCH_HISTORY_RESULT = 2421, // 0x00000975
      [Token(Token = "0x4003287"), GameParameter.ParameterDesc("ランクマッチの戦績の変動ポイント")] RANKMATCH_HISTORY_VALUE = 2422, // 0x00000976
      [Token(Token = "0x4003288"), GameParameter.ParameterDesc("ランクマッチの戦績のクラスアイコン")] RANKMATCH_HISTORY_CLASS = 2423, // 0x00000977
      [Token(Token = "0x4003289"), GameParameter.ParameterDesc("ランクマッチの戦績のユーザー名")] RANKMATCH_HISTORY_NAME = 2424, // 0x00000978
      [Token(Token = "0x400328A"), GameParameter.ParameterDesc("ランクマッチの戦績のユーザーランク")] RANKMATCH_HISTORY_LEVEL = 2425, // 0x00000979
      [Token(Token = "0x400328B"), GameParameter.ParameterDesc("ランクマッチの戦績のスコア")] RANKMATCH_HISTORY_SCORE = 2426, // 0x0000097A
      [Token(Token = "0x400328C"), GameParameter.ParameterDesc("ランクマッチのミッション名")] RANKMATCH_MISSION_NAME = 2427, // 0x0000097B
      [Token(Token = "0x400328D"), GameParameter.ParameterDesc("ランクマッチのミッションの必要回数")] RANKMATCH_MISSION_NEED = 2428, // 0x0000097C
      [Token(Token = "0x400328E"), GameParameter.ParameterDesc("ランクマッチのミッションの進行度")] RANKMATCH_MISSION_PROGRESS = 2429, // 0x0000097D
      [Token(Token = "0x400328F"), GameParameter.InstanceTypes(typeof (GameParameter.RankMatchPlayer)), GameParameter.ParameterDesc("プレイヤーのランクマッチのクラス")] GLOBAL_PLAYER_RANKMATCH_CLASSNAME = 2430, // 0x0000097E
      [Token(Token = "0x4003290"), GameParameter.ParameterDesc("プレイヤーのランクマッチの対戦回数")] GLOBAL_PLAYER_RANKMATCH_COUNT_TOTAL = 2431, // 0x0000097F
      [Token(Token = "0x4003291"), GameParameter.ParameterDesc("プレイヤーのランクマッチの対戦勝利数")] GLOBAL_PLAYER_RANKMATCH_COUNT_WIN = 2432, // 0x00000980
      [Token(Token = "0x4003292"), GameParameter.ParameterDesc("プレイヤーのランクマッチの対戦敗北数")] GLOBAL_PLAYER_RANKMATCH_COUNT_LOSE = 2433, // 0x00000981
      [Token(Token = "0x4003293"), GameParameter.ParameterDesc("プレイヤーのランクマッチのスコアゲージ")] GLOBAL_PLAYER_RANKMATCH_SCORE_GAUGE = 2434, // 0x00000982
      [Token(Token = "0x4003294")] RANKMATCH_RANKING_RANKREWARD_IMAGESET_SPERATE = 2435, // 0x00000983
      [Token(Token = "0x4003295"), GameParameter.ParameterDesc("ランクマッチのミッションの報酬受取可能ならActiveに"), GameParameter.AlwaysUpdate] RANKMATCH_MISSION_COMPLETED_ACTIVE = 2436, // 0x00000984
      [Token(Token = "0x4003296"), GameParameter.ParameterDesc("ランクマッチのシーズン報酬ランキングの順位(3位以上なら非表示になる)")] RANKMATCH_RESULT_RANK_NUM = 2437, // 0x00000985
      [Token(Token = "0x4003297"), GameParameter.ParameterDesc("ランクマッチのシーズン報酬ランキングの順位アイコン(4位以下なら非表示になる)")] RANKMATCH_RESULT_RANK_ICON = 2438, // 0x00000986
      [Token(Token = "0x4003298"), GameParameter.ParameterDesc("ランクマッチのシーズン報酬ランキングのクラスアイコン")] RANKMATCH_RESULT_CLASS = 2439, // 0x00000987
      [Token(Token = "0x4003299"), GameParameter.ParameterDesc("ランクマッチのシーズン報酬ランキングのスコア")] RANKMATCH_RESULT_SCORE = 2440, // 0x00000988
      [Token(Token = "0x400329A"), GameParameter.ParameterDesc("対戦相手のランクマッチスコア")] VERSUS_PLAYER_RANKMATCHSCORE = 2441, // 0x00000989
      [Token(Token = "0x400329B"), GameParameter.ParameterDesc("ランクマッチのシーズン報酬ランキングのクラス名")] RANKMATCH_RESULT_CLASS_NAME = 2442, // 0x0000098A
      [Token(Token = "0x400329C"), GameParameter.ParameterDesc("ランクマッチのシーズン期間")] RANKMATCH_RESULT_PERIOD = 2443, // 0x0000098B
      [Token(Token = "0x400329D"), GameParameter.ParameterDesc("ランクマッチのタイトル")] RANKMATCH_TITLE = 2444, // 0x0000098C
      [Token(Token = "0x400329E"), GameParameter.ParameterDesc("闘技場の順位アイコン")] ARENA_RANKING_RANK_ICON = 2445, // 0x0000098D
      [Token(Token = "0x400329F"), GameParameter.ParameterDesc("闘技場パーティのリーダースキルの背景画像")] ARENA_LEADERSKILL_IMAGE = 2446, // 0x0000098E
      [Token(Token = "0x40032A0"), GameParameter.ParameterDesc("闘技場プレイヤーのリーダースキルの背景画像"), GameParameter.InstanceTypes(typeof (GameParameter.ArenaPlayerInstanceTypes))] ARENAPLAYER_LEADERSKILLIMAGE = 2447, // 0x0000098F
      [Token(Token = "0x40032A1")] GLOBAL_PLAYER_RANKMATCH_ED = 2498, // 0x000009C2
      [Token(Token = "0x40032A2")] ABILITY_ST = 2499, // 0x000009C3
      [Token(Token = "0x40032A3"), GameParameter.ParameterDesc("派生アビリティならActiveになる"), GameParameter.AlwaysUpdate] ABILITY_DERIVED_BADGE = 2500, // 0x000009C4
      [Token(Token = "0x40032A4"), GameParameter.ParameterDesc("派生アビリティならテキストの色が変わる")] ABILITY_DERIVED_TEXTCOLOR = 2501, // 0x000009C5
      [Token(Token = "0x40032A5"), GameParameter.ParameterDesc("アビリティの種類詳細によってタイトルが変わる（SpriteSheet）")] ABILITY_TITLE_DETAIL_TYPE = 2502, // 0x000009C6
      [Token(Token = "0x40032A6"), GameParameter.ParameterDesc("アビリティの最大RANK")] ABILITY_RANKCAP = 2503, // 0x000009C7
      [Token(Token = "0x40032A7"), GameParameter.ParameterDesc("アビリティのRANK(色変化付き)")] ABILITY_ADDRANK = 2504, // 0x000009C8
      [Token(Token = "0x40032A8")] ABILITY_ED = 2598, // 0x00000A26
      [Token(Token = "0x40032A9")] SKILL_ST = 2599, // 0x00000A27
      [Token(Token = "0x40032AA"), GameParameter.ParameterDesc("派生スキルならテキストの色が変わる")] SKILL_DERIVED_TEXTCOLOR = 2600, // 0x00000A28
      [Token(Token = "0x40032AB")] SKILL_ED = 2698, // 0x00000A8A
      [Token(Token = "0x40032AC")] ARTIFACT_SETEFFECT_ST = 2699, // 0x00000A8B
      [Token(Token = "0x40032AD"), GameParameter.ParameterDesc("セット効果の発動条件のアイコン"), GameParameter.UsesIndex] ARTIFACT_SETEFFECT_TRIGGER_ICON = 2700, // 0x00000A8C
      [Token(Token = "0x40032AE")] ARTIFACT_SETEFFECT_ED = 2798, // 0x00000AEE
      [Token(Token = "0x40032AF")] CONCEPTCARD_ST = 2799, // 0x00000AEF
      [Token(Token = "0x40032B0"), GameParameter.ParameterDesc("真理念装の限界突破回数を示すアイコン")] CONCEPTCARD_AWAKE = 2800, // 0x00000AF0
      [Token(Token = "0x40032B1"), GameParameter.ParameterDesc("真理念装の限界突破回数を示す星アイコン")] CONCEPTCARD_AWAKESTAR = 2801, // 0x00000AF1
      [Token(Token = "0x40032B2"), GameParameter.ParameterDesc("真理念装のグループアイコン")] CONCEPTCARD_GROUPICON = 2802, // 0x00000AF2
      [Token(Token = "0x40032B3")] CONCEPTCARD_ED = 2898, // 0x00000B52
      [Token(Token = "0x40032B4")] GAMEOBJECT_ST = 2899, // 0x00000B53
      [Token(Token = "0x40032B5"), GameParameter.ParameterDesc("ゲームオブジェクトの表示/非表示")] GAMEOBJECT_ACTIVE = 2900, // 0x00000B54
      [Token(Token = "0x40032B6")] GAMEOBJECT_INACTIVE = 2901, // 0x00000B55
      [Token(Token = "0x40032B7")] GAMEOBJECT_ED = 2998, // 0x00000BB6
      [Token(Token = "0x40032B8")] GUILD_ST = 2999, // 0x00000BB7
      [Token(Token = "0x40032B9"), GameParameter.ParameterDesc("ギルド名")] GUILD_NAME = 3000, // 0x00000BB8
      [Token(Token = "0x40032BA"), GameParameter.ParameterDesc("ギルドエンブレム")] GUILD_EMBLEM = 3001, // 0x00000BB9
      [Token(Token = "0x40032BB"), GameParameter.ParameterDesc("ギルド掲示板")] GUILD_BOARD = 3002, // 0x00000BBA
      [Token(Token = "0x40032BC"), GameParameter.ParameterDesc("ギルドメンバー数")] GUILD_MEMBER_COUNT = 3003, // 0x00000BBB
      [Token(Token = "0x40032BD"), GameParameter.ParameterDesc("ギルドメンバー最大数")] GUILD_MEMBER_COUNTMAX = 3004, // 0x00000BBC
      [Token(Token = "0x40032BE"), GameParameter.ParameterDesc("ギルドメンバー名前")] GUILD_MEMBER_NAME = 3005, // 0x00000BBD
      [Token(Token = "0x40032BF"), GameParameter.ParameterDesc("ギルドメンバーのレベル")] GUILD_MEMBER_LEVEL = 3006, // 0x00000BBE
      [Token(Token = "0x40032C0"), GameParameter.ParameterDesc("ギルドメンバーの最終ログイン日時")] GUILD_MEMBER_LASTLOGIN = 3007, // 0x00000BBF
      [Token(Token = "0x40032C1"), GameParameter.ParameterDesc("ギルドレベル")] GUILD_LEVEL = 3008, // 0x00000BC0
      [Token(Token = "0x40032C2"), GameParameter.ParameterDesc("ギルド加入条件：レベルその1")] GUILD_CONDITIONS_LEVEL1 = 3009, // 0x00000BC1
      [Token(Token = "0x40032C3"), GameParameter.ParameterDesc("ギルド加入条件：レベルその2")] GUILD_CONDITIONS_LEVEL2 = 3010, // 0x00000BC2
      [Token(Token = "0x40032C4"), GameParameter.ParameterDesc("ギルドマスター(表示)")] GUILD_ROLE_MASTER_ACTIVE = 3011, // 0x00000BC3
      [Token(Token = "0x40032C5"), GameParameter.ParameterDesc("サブギルドマスター(表示)")] GUILD_ROLE_SUBMASTER_ACTIVE = 3012, // 0x00000BC4
      [Token(Token = "0x40032C6"), GameParameter.ParameterDesc("ギルドマスorサブマス(表示)")] GUILD_ROLE_MANAGER_ACTIVE = 3013, // 0x00000BC5
      [Token(Token = "0x40032C7"), GameParameter.ParameterDesc("ギルドマスorサブマス(非表示)")] GUILD_ROLE_MANAGER_INACTIVE = 3014, // 0x00000BC6
      [Token(Token = "0x40032C8"), GameParameter.ParameterDesc("ギルドマスター名")] GUILD_MASTER_NAME = 3015, // 0x00000BC7
      [Token(Token = "0x40032C9"), GameParameter.ParameterDesc("ギルド募集メッセージ")] GUILD_INVITE_MESSAGE = 3016, // 0x00000BC8
      [Token(Token = "0x40032CA"), GameParameter.ParameterDesc("ギルド役職画像")] GUILD_ROLE_IMAGE = 3017, // 0x00000BC9
      [Token(Token = "0x40032CB"), GameParameter.ParameterDesc("ギルド自動承認ON/OFF")] GUILD_AUTOAPPROVAL = 3018, // 0x00000BCA
      [Token(Token = "0x40032CC"), GameParameter.ParameterDesc("ギルドマスターのユニット")] GUILD_MASTER_UNIT = 3019, // 0x00000BCB
      [Token(Token = "0x40032CD"), GameParameter.ParameterDesc("ギルドID")] GUILD_ID = 3020, // 0x00000BCC
      [Token(Token = "0x40032CE"), GameParameter.ParameterDesc("ギルド設立日")] GUILD_CREATEDAT = 3021, // 0x00000BCD
      [Token(Token = "0x40032CF"), GameParameter.ParameterDesc("ギルド施設強化の1日の上限値")] GUILD_FACILITY_INVEST_LIMIT = 3022, // 0x00000BCE
      [Token(Token = "0x40032D0"), GameParameter.ParameterDesc("現在のギルド施設強化値")] GUILD_FACILITY_INVEST_CURRENT = 3023, // 0x00000BCF
      [Token(Token = "0x40032D1"), GameParameter.ParameterDesc("ギルド施設の画像")] GUILD_FACILITY_IMAGE = 3024, // 0x00000BD0
      [Token(Token = "0x40032D2"), GameParameter.ParameterDesc("他人ギルド名")] GUILD_OTHER_NAME = 3025, // 0x00000BD1
      [Token(Token = "0x40032D3"), GameParameter.ParameterDesc("他人ギルドエンブレム")] GUILD_OTHER_EMBLEM = 3026, // 0x00000BD2
      [Token(Token = "0x40032D4"), GameParameter.ParameterDesc("他人ギルドレベル")] GUILD_OTHER_LEVEL = 3027, // 0x00000BD3
      [Token(Token = "0x40032D5"), GameParameter.ParameterDesc("他人ギルドの人数")] GUILD_OTHER_MEMBER_COUNT = 3028, // 0x00000BD4
      [Token(Token = "0x40032D6"), GameParameter.ParameterDesc("他人ギルドの最大人数")] GUILD_OTHER_MEMBER_COUNTMAX = 3029, // 0x00000BD5
      [Token(Token = "0x40032D7"), GameParameter.ParameterDesc("他人ギルド加入中にON")] GUILD_OTHER_TOGGLE_ON = 3030, // 0x00000BD6
      [Token(Token = "0x40032D8"), GameParameter.ParameterDesc("他人ギルド加入中にOFF")] GUILD_OTHER_TOGGLE_OFF = 3031, // 0x00000BD7
      [Token(Token = "0x40032D9"), GameParameter.ParameterDesc("ギルドメンバー表示時の枠画像")] GUILD_MEMBER_FRAMEIMAGE = 3032, // 0x00000BD8
      [Token(Token = "0x40032DA"), GameParameter.ParameterDesc("ギルド加入中にON")] GUILD_SELF_TOGGLE_ON = 3033, // 0x00000BD9
      [Token(Token = "0x40032DB"), GameParameter.ParameterDesc("ギルド加入中にOFF")] GUILD_SELF_TOGGLE_OFF = 3034, // 0x00000BDA
      [Token(Token = "0x40032DC"), GameParameter.ParameterDesc("ギルド名")] GUILD_SELF_NAME = 3035, // 0x00000BDB
      [Token(Token = "0x40032DD"), GameParameter.ParameterDesc("ギルド施設レベル")] GUILD_FACILITY_LEVEL = 3036, // 0x00000BDC
      [Token(Token = "0x40032DE"), GameParameter.InstanceTypes(typeof (GameParameter.ItemInstanceTypes)), GameParameter.ParameterDesc("ギルド施設強化アイテムのポイント値")] GUILD_FACILITY_ENHANCEPOINT = 3037, // 0x00000BDD
      [Token(Token = "0x40032DF"), GameParameter.ParameterDesc("ギルドに所属しているなら表示/所属してないなら非表示")] GUILD_JOIN = 3038, // 0x00000BDE
      [Token(Token = "0x40032E0"), GameParameter.ParameterDesc("他人ギルドマスター名")] GUILD_OTHER_MASTERNAME = 3039, // 0x00000BDF
      [Token(Token = "0x40032E1"), GameParameter.ParameterDesc("ギルドのポートレイドが開放されてるかどうか？")] GUILD_GUILDRAIDOPEN = 3040, // 0x00000BE0
      [Token(Token = "0x40032E2"), GameParameter.ParameterDesc("ギルドのポートレイドが閉じているかどうか？")] GUILD_GUILDRAIDCLOSE = 3041, // 0x00000BE1
      [Token(Token = "0x40032E3"), GameParameter.ParameterDesc("他人ギルド設立日")] GUILD_OTHER_CREATEDAT = 3042, // 0x00000BE2
      [Token(Token = "0x40032E4"), GameParameter.ParameterDesc("ポート出席報酬の未受け取りバッジ")] GUILD_BADGE_ATTEND = 3043, // 0x00000BE3
      [Token(Token = "0x40032E5"), GameParameter.ParameterDesc("ポートMaster/SubMaster報酬の未受け取りバッジ")] GUILD_BADGE_ROLE_BONUS = 3044, // 0x00000BE4
      [Token(Token = "0x40032E6"), GameParameter.ParameterDesc("ポートへの出席状況画像")] GUILD_ATTEND_STATUS = 3045, // 0x00000BE5
      [Token(Token = "0x40032E7"), GameParameter.ParameterDesc("ポート方針")] GUILD_CONDITIONS_POLICY = 3046, // 0x00000BE6
      [Token(Token = "0x40032E8"), GameParameter.ParameterDesc("ポートショップレベル")] GUILD_FACILITY_SHOP_LEVEL = 3047, // 0x00000BE7
      [Token(Token = "0x40032E9"), GameParameter.ParameterDesc("本部レベル")] GUILD_FACILITY_BASE_LEVEL = 3048, // 0x00000BE8
      [Token(Token = "0x40032EA"), GameParameter.ParameterDesc("自身のギルドの場合アクティブになるオブジェクト"), GameParameter.AlwaysUpdate] GUILD_OWNGUILD_ACTIVE = 3049, // 0x00000BE9
      [Token(Token = "0x40032EB"), GameParameter.ParameterDesc("自身のギルドではない場合アクティブになるオブジェクト"), GameParameter.AlwaysUpdate] GUILD_OWNGUILD_NONACTIVE = 3050, // 0x00000BEA
      [Token(Token = "0x40032EC"), GameParameter.ParameterDesc("ポートミッション報酬の未受け取りバッジ"), GameParameter.AlwaysUpdate] GUILD_BADGE_TROPHY_REWARD = 3051, // 0x00000BEB
      [Token(Token = "0x40032ED"), GameParameter.ParameterDesc("ポート鍛錬場受け取り可能バッジ"), GameParameter.AlwaysUpdate] GUILD_TRAINING_FINISH_BADGE = 3052, // 0x00000BEC
      [Token(Token = "0x40032EE")] GUILD_ED = 3098, // 0x00000C1A
      [Token(Token = "0x40032EF")] BUTTON_ST = 3099, // 0x00000C1B
      [Token(Token = "0x40032F0"), GameParameter.ParameterDesc("ボタンの有効/無効")] BUTTON_INTERACTABLE = 3100, // 0x00000C1C
      [Token(Token = "0x40032F1")] BUTTON_ED = 3198, // 0x00000C7E
      [Token(Token = "0x40032F2")] RAID_ST = 3199, // 0x00000C7F
      [Token(Token = "0x40032F3"), GameParameter.ParameterDesc("レイド名")] RAID_NAME = 3200, // 0x00000C80
      [Token(Token = "0x40032F4"), GameParameter.ParameterDesc("レイドHP数値")] RAID_HP_VALUE = 3201, // 0x00000C81
      [Token(Token = "0x40032F5"), GameParameter.ParameterDesc("レイド最大HP")] RAID_HP_MAX = 3202, // 0x00000C82
      [Token(Token = "0x40032F6"), GameParameter.ParameterDesc("レイドHP％")] RAID_HP_PERCENT = 3203, // 0x00000C83
      [Token(Token = "0x40032F7"), GameParameter.ParameterDesc("レイドHPゲージ")] RAID_HP_GAUGE = 3204, // 0x00000C84
      [Token(Token = "0x40032F8"), GameParameter.ParameterDesc("レイドアイコン")] RAID_ICON_MEDIUM = 3205, // 0x00000C85
      [Token(Token = "0x40032F9"), GameParameter.ParameterDesc("レイド一枚絵")] RAID_IMAGE = 3206, // 0x00000C86
      [Token(Token = "0x40032FA"), GameParameter.ParameterDesc("レイド救援一覧レイドアイコン")] RAID_RESCUE_RAID_ICON = 3207, // 0x00000C87
      [Token(Token = "0x40032FB"), GameParameter.ParameterDesc("レイド救援一覧レイドレベル（周回数）")] RAID_RESCUE_RAID_ROUND = 3208, // 0x00000C88
      [Token(Token = "0x40032FC"), GameParameter.ParameterDesc("レイド救援一覧レイド名")] RAID_RESCUE_RAID_NAME = 3209, // 0x00000C89
      [Token(Token = "0x40032FD"), GameParameter.ParameterDesc("レイド救援一覧レイドエリア")] RAID_RESCUE_RAID_AREAORDER = 3210, // 0x00000C8A
      [Token(Token = "0x40032FE"), GameParameter.ParameterDesc("レイド救援一覧プレイヤー名")] RAID_RESCUE_PLAYER_NAME = 3211, // 0x00000C8B
      [Token(Token = "0x40032FF"), GameParameter.ParameterDesc("レイド救援一覧プレイヤーLV")] RAID_RESCUE_PLAYER_LEVEL = 3212, // 0x00000C8C
      [Token(Token = "0x4003300"), GameParameter.ParameterDesc("レイド救援一覧残り時間")] RAID_RESCUE_REMAIN = 3213, // 0x00000C8D
      [Token(Token = "0x4003301"), GameParameter.ParameterDesc("レイド救援一覧HP数値")] RAID_RESCUE_RAID_HP_VALUE = 3214, // 0x00000C8E
      [Token(Token = "0x4003302"), GameParameter.ParameterDesc("レイド救援一覧最大HP")] RAID_RESCUE_RAID_HP_MAX = 3215, // 0x00000C8F
      [Token(Token = "0x4003303"), GameParameter.ParameterDesc("レイド救援一覧HP％")] RAID_RESCUE_RAID_HP_PERCENT = 3216, // 0x00000C90
      [Token(Token = "0x4003304"), GameParameter.ParameterDesc("レイド救援一覧HPゲージ")] RAID_RESCUE_RAID_HP_GAUGE = 3217, // 0x00000C91
      [Token(Token = "0x4003305"), GameParameter.ParameterDesc("レイド救援一覧プレイヤータイプ"), GameParameter.AlwaysUpdate] RAID_RESCUE_PLAYER_TYPE = 3218, // 0x00000C92
      [Token(Token = "0x4003306"), GameParameter.ParameterDesc("レイド救援プレイヤー名")] RAID_SOS_PLAYER_NAME = 3219, // 0x00000C93
      [Token(Token = "0x4003307"), GameParameter.ParameterDesc("レイド救援プレイヤーLV")] RAID_SOS_PLAYER_LEVEL = 3220, // 0x00000C94
      [Token(Token = "0x4003308"), GameParameter.ParameterDesc("レイド救援プレイヤータイプ"), GameParameter.AlwaysUpdate] RAID_SOS_PLAYER_TYPE = 3221, // 0x00000C95
      [Token(Token = "0x4003309"), GameParameter.ParameterDesc("レイド救援プレイヤー最終攻撃時間")] RAID_SOS_BATTLETIME = 3222, // 0x00000C96
      [Token(Token = "0x400330A"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("レイド詳細撃挑戦ボタン")] RAID_BUTTON_CHALLENGE = 3223, // 0x00000C97
      [Token(Token = "0x400330B"), GameParameter.AlwaysUpdate, GameParameter.InstanceTypes(typeof (GameParameter.RaidRescueStatusType)), GameParameter.ParameterDesc("レイド詳細救援ボタン")] RAID_BUTTON_RESCUE_SEND = 3224, // 0x00000C98
      [Token(Token = "0x400330C"), GameParameter.ParameterDesc("レイド詳細救援終了ボタン"), GameParameter.AlwaysUpdate] RAID_BUTTON_RESCUE_CANCEL = 3225, // 0x00000C99
      [Token(Token = "0x400330D"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("レイド詳細撃破報酬受取ボタン")] RAID_BUTTON_REWARD = 3226, // 0x00000C9A
      [Token(Token = "0x400330E"), GameParameter.ParameterDesc("ホームのレイドアイコン")] RAID_PERIOD_BUTTON = 3227, // 0x00000C9B
      [Token(Token = "0x400330F"), GameParameter.ParameterDesc("レイドHPゲージカラー")] RAID_HP_GAUGE_COLOR = 3228, // 0x00000C9C
      [Token(Token = "0x4003310"), GameParameter.ParameterDesc("レイド救援一覧プレイヤーユニット")] RAID_RESCUE_PLAYER_UNIT = 3229, // 0x00000C9D
      [Token(Token = "0x4003311"), GameParameter.ParameterDesc("レイド救援プレイヤーユニット")] RAID_SOS_PLAYER_UNIT = 3230, // 0x00000C9E
      [Token(Token = "0x4003312"), GameParameter.ParameterDesc("レイド救援一覧プレイヤー称号")] RAID_RESCUE_PLAYER_AWARD = 3231, // 0x00000C9F
      [Token(Token = "0x4003313"), GameParameter.ParameterDesc("レイド救援一覧プレイヤー最終ログイン日時")] RAID_RESCUE_PLAYER_LASTLOGIN = 3232, // 0x00000CA0
      [Token(Token = "0x4003314"), GameParameter.ParameterDesc("レイド撃破ランキングランク画像")] RAID_RANKING_BEAT_RANK_IMAGE = 3233, // 0x00000CA1
      [Token(Token = "0x4003315"), GameParameter.ParameterDesc("レイド撃破ランキングランクテキスト")] RAID_RANKING_BEAT_RANK_TEXT = 3234, // 0x00000CA2
      [Token(Token = "0x4003316"), GameParameter.ParameterDesc("レイド撃破ランキングスコア")] RAID_RANKING_BEAT_SCORE = 3235, // 0x00000CA3
      [Token(Token = "0x4003317"), GameParameter.ParameterDesc("レイド撃破ランキングプレイヤー名")] RAID_RANKING_BEAT_NAME = 3236, // 0x00000CA4
      [Token(Token = "0x4003318"), GameParameter.ParameterDesc("レイド撃破ランキングプレイヤーレベル")] RAID_RANKING_BEAT_LEVEL = 3237, // 0x00000CA5
      [Token(Token = "0x4003319"), GameParameter.ParameterDesc("レイド属性")] RAID_ELEMENT = 3238, // 0x00000CA6
      [Token(Token = "0x400331A"), GameParameter.ParameterDesc("レイド救援一覧レイド属性")] RAID_RESCUE_RAID_ELEMENT = 3239, // 0x00000CA7
      [Token(Token = "0x400331B"), GameParameter.ParameterDesc("レイドギルドランキングランク画像")] RAID_RANKING_GUILD_RANK_IMAGE = 3240, // 0x00000CA8
      [Token(Token = "0x400331C"), GameParameter.ParameterDesc("レイドギルドランキングランクテキスト")] RAID_RANKING_GUILD_RANK_TEXT = 3241, // 0x00000CA9
      [Token(Token = "0x400331D"), GameParameter.ParameterDesc("レイドギルドランキングスコア")] RAID_RANKING_GUILD_SCORE = 3242, // 0x00000CAA
      [Token(Token = "0x400331E"), GameParameter.ParameterDesc("レイドギルドランキングプレイヤーレベル")] RAID_RANKING_GUILD_LEVEL = 3243, // 0x00000CAB
      [Token(Token = "0x400331F"), GameParameter.ParameterDesc("レイドギルド進捗ボタン")] RAID_GUILD_STATS_BUTTON = 3244, // 0x00000CAC
      [Token(Token = "0x4003320"), GameParameter.ParameterDesc("レイドギルド進捗撃破ランク")] RAID_GUILD_STATS_BEAT_RANK = 3245, // 0x00000CAD
      [Token(Token = "0x4003321"), GameParameter.ParameterDesc("レイドギルド進捗撃破スコア")] RAID_GUILD_STATS_BEAT_SCORE = 3246, // 0x00000CAE
      [Token(Token = "0x4003322"), GameParameter.ParameterDesc("レイドギルド進捗救援撃破ランク")] RAID_GUILD_STATS_RESCUE_RANK = 3247, // 0x00000CAF
      [Token(Token = "0x4003323"), GameParameter.ParameterDesc("レイドギルド進捗救援撃破スコア")] RAID_GUILD_STATS_RESCUE_SCORE = 3248, // 0x00000CB0
      [Token(Token = "0x4003324"), GameParameter.ParameterDesc("レイドギルド進捗メンバー撃破スコア")] RAID_GUILD_STATS_MEMBER_BEAT_SCORE = 3249, // 0x00000CB1
      [Token(Token = "0x4003325"), GameParameter.ParameterDesc("レイドギルド進捗メンバー救援撃破スコア")] RAID_GUILD_STATS_MEMBER_RESCUE_SCORE = 3250, // 0x00000CB2
      [Token(Token = "0x4003326"), GameParameter.ParameterDesc("レイドギルド進捗メンバー周回数")] RAID_GUILD_STATS_MEMBER_LAP = 3251, // 0x00000CB3
      [Token(Token = "0x4003327"), GameParameter.ParameterDesc("レイドスタンプラリーボタン")] RAID_STAMPRALLY = 3252, // 0x00000CB4
      [Token(Token = "0x4003328"), GameParameter.ParameterDesc("一番近いレイドが開催されている時間帯を取得する")] RAID_SCHEDULE_TIMEGET = 3253, // 0x00000CB5
      [Token(Token = "0x4003329"), GameParameter.ParameterDesc("レイドが開催されているなら非表示")] RAID_SCHEDULE_OPENNODRAW = 3254, // 0x00000CB6
      [Token(Token = "0x400332A"), GameParameter.ParameterDesc("レイドが開催してないなら非表示")] RAID_SCHEDULE_CLOSENODRAW = 3255, // 0x00000CB7
      [Token(Token = "0x400332B"), GameParameter.ParameterDesc("レイドが開催してないならクリック不可")] RAID_SCHEDULE_CLOSEINTRACTALE = 3256, // 0x00000CB8
      [Token(Token = "0x400332C"), GameParameter.ParameterDesc("レイド詳細画面の休戦中ボタン")] RAID_BUTTON_INFOSCHEDULECLOSE = 3257, // 0x00000CB9
      [Token(Token = "0x400332D"), GameParameter.ParameterDesc("レイドのスケジュールが登録されてないなら非表示")] RAID_BUTTON_NOSHEDULE = 3258, // 0x00000CBA
      [Token(Token = "0x400332E"), GameParameter.ParameterDesc("次回開催中のみ表示")] RAID_BUTTON_CLOTHSCHEDULE = 3259, // 0x00000CBB
      [Token(Token = "0x400332F"), GameParameter.ParameterDesc("レイドランキング結果の開催期間")] RAID_RANKREWARD_PERIODID = 3260, // 0x00000CBC
      [Token(Token = "0x4003330"), GameParameter.ParameterDesc("レイドランキング結果の個人ランク")] RAID_RANKREWARD_RANK = 3261, // 0x00000CBD
      [Token(Token = "0x4003331"), GameParameter.ParameterDesc("レイドランキング結果の個人スコア")] RAID_RANKREWARD_SCORE = 3262, // 0x00000CBE
      [Token(Token = "0x4003332"), GameParameter.ParameterDesc("レイドランキング結果の救援ランク")] RAID_RANKREWARD_RESQUERANK = 3263, // 0x00000CBF
      [Token(Token = "0x4003333"), GameParameter.ParameterDesc("レイドランキング結果の救援スコア")] RAID_RANKREWARD_RESQUESCORE = 3264, // 0x00000CC0
      [Token(Token = "0x4003334"), GameParameter.ParameterDesc("レイドランキング結果のギルドランク")] RAID_RANKREWARD_GUILDRANK = 3265, // 0x00000CC1
      [Token(Token = "0x4003335"), GameParameter.ParameterDesc("レイドランキング結果のギルドスコア")] RAID_RANKREWARD_GUILDSCORE = 3266, // 0x00000CC2
      [Token(Token = "0x4003336"), GameParameter.ParameterDesc("レイドランキング結果のギルドアイコン")] RAID_RANKREWARD_GUILDAWARD = 3267, // 0x00000CC3
      [Token(Token = "0x4003337"), GameParameter.ParameterDesc("レイドランキング結果のギルド名")] RAID_RANKREWARD_GUILDNAME = 3268, // 0x00000CC4
      [Token(Token = "0x4003338"), GameParameter.ParameterDesc("レイドランキング結果のギルドLv")] RAID_RANKREWARD_GUILDLEVEL = 3269, // 0x00000CC5
      [Token(Token = "0x4003339"), GameParameter.ParameterDesc("レイドランキング結果のギルドマスターの名前")] RAID_RANKREWARD_GUILDMASTERNAME = 3270, // 0x00000CC6
      [Token(Token = "0x400333A"), GameParameter.ParameterDesc("レイドランキング結果のギルドメンバー数")] RAID_RANKREWARD_GUILDMEMBER = 3271, // 0x00000CC7
      [Token(Token = "0x400333B"), GameParameter.ParameterDesc("レイドランキング結果のギルド最大メンバー数")] RAID_RANKREWARD_GUILDMAXMEMBER = 3272, // 0x00000CC8
      [Token(Token = "0x400333C")] RAID_ED = 3298, // 0x00000CE2
      [Token(Token = "0x400333D")] GENESIS_ST = 3299, // 0x00000CE3
      [Token(Token = "0x400333E"), GameParameter.ParameterDesc("創世編ボス名")] GENESIS_BOSS_NAME = 3300, // 0x00000CE4
      [Token(Token = "0x400333F"), GameParameter.ParameterDesc("創世編ボス一枚絵")] GENESIS_BOSS_IMAGE = 3301, // 0x00000CE5
      [Token(Token = "0x4003340"), GameParameter.ParameterDesc("創世編ボス属性アイコン")] GENESIS_BOSS_ELEMENT = 3302, // 0x00000CE6
      [Token(Token = "0x4003341"), GameParameter.ParameterDesc("創世編ボス現在HP")] GENESIS_BOSS_HP_CURRENT = 3303, // 0x00000CE7
      [Token(Token = "0x4003342"), GameParameter.ParameterDesc("創世編ボス最大HP")] GENESIS_BOSS_HP_MAX = 3304, // 0x00000CE8
      [Token(Token = "0x4003343"), GameParameter.ParameterDesc("創世編ボスHPゲージ")] GENESIS_BOSS_HP_GAUGE = 3305, // 0x00000CE9
      [Token(Token = "0x4003344"), GameParameter.ParameterDesc("創世編ボス挑戦ボタン")] GENESIS_BOSS_CHALLENGE_BUTTON = 3306, // 0x00000CEA
      [Token(Token = "0x4003345"), GameParameter.ParameterDesc("創世編ボスExtra存在するなら表示(0)/非表示(1)")] GENESIS_BOSS_IS_EXIST_EXTRA = 3307, // 0x00000CEB
      [Token(Token = "0x4003346"), GameParameter.ParameterDesc("創世編周回ボスなら表示(0)/非表示(1)")] GENESIS_BOSS_IS_LAP_BOSS = 3308, // 0x00000CEC
      [Token(Token = "0x4003347"), GameParameter.ParameterDesc("創世編周回ボスラップ数")] GENESIS_BOSS_LAP_COUNT = 3309, // 0x00000CED
      [Token(Token = "0x4003348"), GameParameter.ParameterDesc("創世編章TOP開催期間")] GENESIS_CHAPTER_PERIOD = 3319, // 0x00000CF7
      [Token(Token = "0x4003349"), GameParameter.ParameterDesc("創世編開催期間中であれば表示(0)/非表示(1)")] GENESIS_IS_CHECK_PERIOD = 3339, // 0x00000D0B
      [Token(Token = "0x400334A")] GENESIS_ED = 3398, // 0x00000D46
      [Token(Token = "0x400334B")] ADVANCE_ST = 3399, // 0x00000D47
      [Token(Token = "0x400334C"), GameParameter.ParameterDesc("新イベントボス名")] ADVANCE_BOSS_NAME = 3400, // 0x00000D48
      [Token(Token = "0x400334D"), GameParameter.ParameterDesc("新イベントボス一枚絵")] ADVANCE_BOSS_IMAGE = 3401, // 0x00000D49
      [Token(Token = "0x400334E"), GameParameter.ParameterDesc("新イベントボス属性アイコン")] ADVANCE_BOSS_ELEMENT = 3402, // 0x00000D4A
      [Token(Token = "0x400334F"), GameParameter.ParameterDesc("新イベントボス現在HP")] ADVANCE_BOSS_HP_CURRENT = 3403, // 0x00000D4B
      [Token(Token = "0x4003350"), GameParameter.ParameterDesc("新イベントボス最大HP")] ADVANCE_BOSS_HP_MAX = 3404, // 0x00000D4C
      [Token(Token = "0x4003351"), GameParameter.ParameterDesc("新イベントボスHPゲージ")] ADVANCE_BOSS_HP_GAUGE = 3405, // 0x00000D4D
      [Token(Token = "0x4003352"), GameParameter.ParameterDesc("新イベントボス挑戦ボタン")] ADVANCE_BOSS_CHALLENGE_BUTTON = 3406, // 0x00000D4E
      [Token(Token = "0x4003353"), GameParameter.ParameterDesc("新イベントボスExtra存在するなら表示(0)/非表示(1)")] ADVANCE_BOSS_IS_EXIST_EXTRA = 3407, // 0x00000D4F
      [Token(Token = "0x4003354"), GameParameter.ParameterDesc("新イベント周回ボスなら表示(0)/非表示(1)")] ADVANCE_BOSS_IS_LAP_BOSS = 3408, // 0x00000D50
      [Token(Token = "0x4003355"), GameParameter.ParameterDesc("新イベント周回ボスラップ数")] ADVANCE_BOSS_LAP_COUNT = 3409, // 0x00000D51
      [Token(Token = "0x4003356"), GameParameter.ParameterDesc("新イベント全体の開催期間")] ADVANCE_PERIOD = 3419, // 0x00000D5B
      [Token(Token = "0x4003357"), GameParameter.ParameterDesc("新イベント(カレント)開催期間")] ADVANCE_EVENT_PERIOD_CURRENT = 3420, // 0x00000D5C
      [Token(Token = "0x4003358"), GameParameter.ParameterDesc("新イベント開催期間")] ADVANCE_EVENT_PERIOD = 3421, // 0x00000D5D
      [Token(Token = "0x4003359"), GameParameter.ParameterDesc("新イベント全体が開催期間中であれば表示(0)/非表示(1)")] ADVANCE_IS_CHECK_PERIOD = 3439, // 0x00000D6F
      [Token(Token = "0x400335A"), GameParameter.ParameterDesc("新イベント(カレント)が開催期間中であれば表示(0)/非表示(1)")] ADVANCE_IS_CHECK_EVENT_PERIOD_CURRENT = 3440, // 0x00000D70
      [Token(Token = "0x400335B"), GameParameter.ParameterDesc("新イベントが開催期間中であれば表示(0)/非表示(1)")] ADVANCE_IS_CHECK_EVENT_PERIOD = 3441, // 0x00000D71
      [Token(Token = "0x400335C")] ADVANCE_ED = 3498, // 0x00000DAA
      [Token(Token = "0x400335D")] EXTRA_KAKERA_ST = 3499, // 0x00000DAB
      [Token(Token = "0x400335E"), GameParameter.ParameterDesc("欠片クエストがエクストラであれば表示/非表示")] EXTRA_KAKERA_DIFFICULTY_SYMBOL = 3500, // 0x00000DAC
      [Token(Token = "0x400335F")] EXTRA_KAKERA_ED = 3598, // 0x00000E0E
      [Token(Token = "0x4003360")] TROPHY_ST = 3599, // 0x00000E0F
      [Token(Token = "0x4003361"), GameParameter.ParameterDesc("トロフィーのスター獲得量")] TROPHY_STAR_COUNT = 3600, // 0x00000E10
      [Token(Token = "0x4003362"), GameParameter.ParameterDesc("スター獲得量が'0'であれば表示(0)/非表示(1)")] TROPHY_STAR_MISSION_IS_CHECK_ZERO_STAR_NUM = 3601, // 0x00000E11
      [Token(Token = "0x4003363")] TROPHY_ED = 3698, // 0x00000E72
      [Token(Token = "0x4003364")] LOGINBONUS_ST = 3699, // 0x00000E73
      [Token(Token = "0x4003365"), GameParameter.ParameterDesc("ログインボーナスの未受け取りバッチの表示/非表示")] LOGINBONUS_IS_NOT_RECEIVED = 3700, // 0x00000E74
      [Token(Token = "0x4003366"), GameParameter.ParameterDesc("ログインボーナスの日付")] LOGINBONUS_DAY = 3701, // 0x00000E75
      [Token(Token = "0x4003367"), GameParameter.ParameterDesc("累計ログイン回数の条件日数")] LOGINBONUS_TOTAL_LOGIN_COUNT_COND_VALUE = 3702, // 0x00000E76
      [Token(Token = "0x4003368"), GameParameter.ParameterDesc("ログインボーナスの補填が可能or累計ログインレコミが受け取れるか")] LOGINBONUS_IS_CAN_REWARD = 3703, // 0x00000E77
      [Token(Token = "0x4003369")] LOGINBONUS_ED = 3798, // 0x00000ED6
      [Token(Token = "0x400336A")] GUILDRAID_ST = 3799, // 0x00000ED7
      [Token(Token = "0x400336B"), GameParameter.ParameterDesc("ギルドレイド名")] GUILDRAID_NAME = 3800, // 0x00000ED8
      [Token(Token = "0x400336C"), GameParameter.ParameterDesc("ギルドレイドHP数値")] GUILDRAID_HP_VALUE = 3801, // 0x00000ED9
      [Token(Token = "0x400336D"), GameParameter.ParameterDesc("ギルドレイド最大HP")] GUILDRAID_HP_MAX = 3802, // 0x00000EDA
      [Token(Token = "0x400336E"), GameParameter.ParameterDesc("ギルドレイドHP％")] GUILDRAID_HP_PERCENT = 3803, // 0x00000EDB
      [Token(Token = "0x400336F"), GameParameter.ParameterDesc("ギルドレイドHPゲージ")] GUILDRAID_HP_GAUGE = 3804, // 0x00000EDC
      [Token(Token = "0x4003370"), GameParameter.ParameterDesc("ギルドレイドアイコン")] GUILDRAID_ICON_MEDIUM = 3805, // 0x00000EDD
      [Token(Token = "0x4003371"), GameParameter.ParameterDesc("ギルドレイド一枚絵")] GUILDRAID_IMAGE = 3806, // 0x00000EDE
      [Token(Token = "0x4003372"), GameParameter.ParameterDesc("ギルドレイド詳細撃挑戦ボタン"), GameParameter.AlwaysUpdate] GUILDRAID_BUTTON_CHALLENGE = 3807, // 0x00000EDF
      [Token(Token = "0x4003373"), GameParameter.ParameterDesc("ギルドレイドHPゲージカラー")] GUILDRAID_HP_GAUGE_COLOR = 3808, // 0x00000EE0
      [Token(Token = "0x4003374"), GameParameter.ParameterDesc("ギルドレイド属性")] GUILDRAID_ELEMENT = 3809, // 0x00000EE1
      [Token(Token = "0x4003375"), GameParameter.ParameterDesc("一番近いギルドレイドが開催されている時間帯を取得する")] GUILDRAID_SCHEDULE_TIMEGET = 3810, // 0x00000EE2
      [Token(Token = "0x4003376"), GameParameter.ParameterDesc("ギルドレイドが開催されているなら非表示")] GUILDRAID_SCHEDULE_OPENNODRAW = 3811, // 0x00000EE3
      [Token(Token = "0x4003377"), GameParameter.ParameterDesc("ギルドレイドが開催してないなら非表示")] GUILDRAID_SCHEDULE_CLOSENODRAW = 3812, // 0x00000EE4
      [Token(Token = "0x4003378"), GameParameter.ParameterDesc("ギルドレイドが開催してないならクリック不可")] GUILDRAID_SCHEDULE_CLOSEINTRACTALE = 3813, // 0x00000EE5
      [Token(Token = "0x4003379"), GameParameter.ParameterDesc("ギルドレイド詳細画面の休戦中ボタン")] GUILDRAID_BUTTON_INFOSCHEDULECLOSE = 3814, // 0x00000EE6
      [Token(Token = "0x400337A"), GameParameter.ParameterDesc("ギルドレイドのスケジュールが登録されてないなら非表示")] GUILDRAID_BUTTON_NOSHEDULE = 3815, // 0x00000EE7
      [Token(Token = "0x400337B"), GameParameter.ParameterDesc("次回開催中のみ表示")] GUILDRAID_BUTTON_CLOTHSCHEDULE = 3816, // 0x00000EE8
      [Token(Token = "0x400337C"), GameParameter.ParameterDesc("ギルドレイド詳細の報酬受取ボタン")] GUILDRAID_BUTTON_REWARD = 3817, // 0x00000EE9
      [Token(Token = "0x400337D"), GameParameter.ParameterDesc("ギルドレイド入り口の画像切り替え(ImageArray番号)\n　(0):終了\n　(1):開催中\n　(2):休戦中")] GUILDRAID_ENTRANCE = 3818, // 0x00000EEA
      [Token(Token = "0x400337E"), GameParameter.ParameterDesc("ギルドレイドBOSSチャレンジ中の名前")] GUILDRAID_CHALLENGE_NAME = 3819, // 0x00000EEB
      [Token(Token = "0x400337F"), GameParameter.ParameterDesc("ギルドレイドBOSSチャレンジ中のレベル")] GUILDRAID_CHALLENGE_LEVEL = 3820, // 0x00000EEC
      [Token(Token = "0x4003380"), GameParameter.ParameterDesc("ギルドレイドBOSSチャレンジ中のユニット")] GUILDRAID_CHALLENGE_UNIT = 3821, // 0x00000EED
      [Token(Token = "0x4003381"), GameParameter.ParameterDesc("ギルドレイドBOSSチャレンジ中のユニットの役職")] GUILDRAID_CHALLENGE_ROLEIMAGE = 3822, // 0x00000EEE
      [Token(Token = "0x4003382"), GameParameter.ParameterDesc("バトルログ：メッセージ")] GUILDRAID_BATTLELOG_MESSAGE = 3823, // 0x00000EEF
      [Token(Token = "0x4003383"), GameParameter.ParameterDesc("バトルログ：日時")] GUILDRAID_BATTLELOG_POSTEDAT = 3824, // 0x00000EF0
      [Token(Token = "0x4003384"), GameParameter.ParameterDesc("ギルドレイド挑戦可能数")] GUILDRAID_BP_CHALLENGE = 3825, // 0x00000EF1
      [Token(Token = "0x4003385"), GameParameter.ParameterDesc("ギルドレイド最大挑戦可能数")] GUILDRAID_BP_MAX = 3826, // 0x00000EF2
      [Token(Token = "0x4003386"), GameParameter.ParameterDesc("ギルドレイドギフト名")] GUILDRAID_GIFT_NAME = 3827, // 0x00000EF3
      [Token(Token = "0x4003387"), GameParameter.ParameterDesc("ギルドランキングのポートレベル")] GUILDRAID_RANKING_GUILD_LEVEL = 3828, // 0x00000EF4
      [Token(Token = "0x4003388"), GameParameter.ParameterDesc("ギルドランキングのポート名")] GUILDRAID_RANKING_GUILD_NAME = 3829, // 0x00000EF5
      [Token(Token = "0x4003389"), GameParameter.ParameterDesc("ギルドランキングのマスター名")] GUILDRAID_RANKING_GUILD_MASTERNAME = 3830, // 0x00000EF6
      [Token(Token = "0x400338A"), GameParameter.ParameterDesc("ギルドランキングのメンバー数")] GUILDRAID_RANKING_GUILD_MEMBER = 3831, // 0x00000EF7
      [Token(Token = "0x400338B"), GameParameter.ParameterDesc("ギルドランキングの最大メンバー数")] GUILDRAID_RANKING_GUILD_MEMBERMAX = 3832, // 0x00000EF8
      [Token(Token = "0x400338C"), GameParameter.ParameterDesc("ギルドランキングのポートスコア")] GUILDRAID_RANKING_GUILD_SCORE = 3833, // 0x00000EF9
      [Token(Token = "0x400338D"), GameParameter.ParameterDesc("ギルドレイドBOSS番号")] GUILDRAID_BOSSNO = 3834, // 0x00000EFA
      [Token(Token = "0x400338E"), GameParameter.ParameterDesc("ギルドレイドアイコン（小）")] GUILDRAID_ICON_SMALL = 3835, // 0x00000EFB
      [Token(Token = "0x400338F"), GameParameter.ParameterDesc("ギルドレイドLAP数")] GUILDRAID_LAP = 3836, // 0x00000EFC
      [Token(Token = "0x4003390"), GameParameter.ParameterDesc("ギルドレイドランキングのランキング")] GUILDRAID_RANKING_GUILD_RANK = 3837, // 0x00000EFD
      [Token(Token = "0x4003391"), GameParameter.ParameterDesc("ギルドレイドTOPのダメージランキングリストのBOSS画像")] GUILDRAID_RANKING_DMGBOSS_BOSSIMAGE = 3838, // 0x00000EFE
      [Token(Token = "0x4003392"), GameParameter.ParameterDesc("ギルドレイドTOPのダメージランキングリストの討伐時間")] GUILDRAID_RANKING_DMGBOSS_BEATTIME = 3839, // 0x00000EFF
      [Token(Token = "0x4003393"), GameParameter.ParameterDesc("ギルドレイドギルド開始期間")] GUILDRAID_OPENSCHEJUDE = 3840, // 0x00000F00
      [Token(Token = "0x4003394"), GameParameter.ParameterDesc("ギルドレイドギルド終了期間")] GUILDRAID_CLOSESCHEJUDE = 3841, // 0x00000F01
      [Token(Token = "0x4003395"), GameParameter.ParameterDesc("ギルドレイドギルド報酬受取開始期間")] GUILDRAID_REWARDOPENSCHEJUDE = 3842, // 0x00000F02
      [Token(Token = "0x4003396"), GameParameter.ParameterDesc("ギルドレイドギルド報酬受取終了期間")] GUILDRAID_REWARDCLOSESCHEJUDE = 3843, // 0x00000F03
      [Token(Token = "0x4003397"), GameParameter.ParameterDesc("ギルドレイドTOP撃挑戦ボタン"), GameParameter.AlwaysUpdate] GUILDRAID_BUTTON_CHALLENGETOP = 3844, // 0x00000F04
      [Token(Token = "0x4003398"), GameParameter.ParameterDesc("ギルドレイドTOP未受け取りギフトバッジ"), GameParameter.AlwaysUpdate] GUILDRAID_MAILBOX_BADGE = 3845, // 0x00000F05
      [Token(Token = "0x4003399"), GameParameter.ParameterDesc("ギルドレイドBOSSチャレンジ中ユニットの開始時間")] GUILDRAID_CHALLENGE_TIME = 3846, // 0x00000F06
      [Token(Token = "0x400339A"), GameParameter.ParameterDesc("ギルドレイド結果の期間")] GUILDRAID_RANKING_REWARD_PERIOD = 3847, // 0x00000F07
      [Token(Token = "0x400339B"), GameParameter.ParameterDesc("ギルドレイド結果のランク")] GUILDRAID_RANKING_REWARD_RANK = 3848, // 0x00000F08
      [Token(Token = "0x400339C"), GameParameter.ParameterDesc("ギルドレイド結果のスコア")] GUILDRAID_RANKING_REWARD_SCORE = 3849, // 0x00000F09
      [Token(Token = "0x400339D"), GameParameter.ParameterDesc("ギルドレイドランキングのエンブレム")] GUILDRAID_RANKING_GUILD_EMBLEM = 3850, // 0x00000F0A
      [Token(Token = "0x400339E"), GameParameter.ParameterDesc("ギルドレイドランキングの順位画像")] GUILDRAID_RANKING_GUILD_RANKIMAGE = 3851, // 0x00000F0B
      [Token(Token = "0x400339F"), GameParameter.ParameterDesc("ギルドレイドランキングの順位文字")] GUILDRAID_RANKING_GUILD_RANKTEXT = 3852, // 0x00000F0C
      [Token(Token = "0x40033A0"), GameParameter.ParameterDesc("ギルドレイド個人ランキングのアイコン")] GUILDRAID_RANKING_MEMBER_ICON = 3853, // 0x00000F0D
      [Token(Token = "0x40033A1"), GameParameter.ParameterDesc("ギルドレイド個人ランキングのギルド役職")] GUILDRAID_RANKING_MEMBER_ROLE = 3854, // 0x00000F0E
      [Token(Token = "0x40033A2"), GameParameter.ParameterDesc("ギルドレイド個人ランキングの名前")] GUILDRAID_RANKING_MEMBER_NAME = 3855, // 0x00000F0F
      [Token(Token = "0x40033A3"), GameParameter.ParameterDesc("ギルドレイド個人ランキングのレベル")] GUILDRAID_RANKING_MEMBER_LEVEL = 3856, // 0x00000F10
      [Token(Token = "0x40033A4"), GameParameter.ParameterDesc("ギルドレイド個人ランキングのスコア")] GUILDRAID_RANKING_MEMBER_SCORE = 3857, // 0x00000F11
      [Token(Token = "0x40033A5"), GameParameter.ParameterDesc("ギルドレイド個人ランキングの総戦闘力")] GUILDRAID_RANKING_MEMBER_POWER = 3858, // 0x00000F12
      [Token(Token = "0x40033A6"), GameParameter.ParameterDesc("ギルドレイド個人ランキングリストのランク画像")] GUILDRAID_RANKING_MEMBER_RANKIMAGE = 3859, // 0x00000F13
      [Token(Token = "0x40033A7"), GameParameter.ParameterDesc("ギルドレイド個人ランキングリストのランクテキスト")] GUILDRAID_RANKING_MEMBER_RANKTEXT = 3860, // 0x00000F14
      [Token(Token = "0x40033A8"), GameParameter.ParameterDesc("ギルドレイドBP残り回数")] GUILDRAID_BP_REMAIN = 3861, // 0x00000F15
      [Token(Token = "0x40033A9"), GameParameter.ParameterDesc("ギルドレイド消費AP")] GUILDRAID_AP_CONSUMPTION = 3862, // 0x00000F16
      [Token(Token = "0x40033AA"), GameParameter.ParameterDesc("ギルドレイド必要最大AP")] GUILDRAID_AP_MAX = 3863, // 0x00000F17
      [Token(Token = "0x40033AB"), GameParameter.ParameterDesc("ギルドレイドTOP画面のランキング")] GUILDRAID_HOME_RANKING_RANK = 3864, // 0x00000F18
      [Token(Token = "0x40033AC"), GameParameter.ParameterDesc("ギルドレイド個人ランキングのランク")] GUILDRAID_RANKING_MEMBER_RANK = 3865, // 0x00000F19
      [Token(Token = "0x40033AD"), GameParameter.ParameterDesc("ギルドレイドBOSS挑戦中のダメージランキングリストのランキング画像")] GUILDRAID_RANKING_DMGBOSS_RANKIMAGE = 3866, // 0x00000F1A
      [Token(Token = "0x40033AE"), GameParameter.ParameterDesc("ギルドレイドBOSS挑戦中のダメージランキングリストのランキング")] GUILDRAID_RANKING_DMGBOSS_RANKTEXT = 3867, // 0x00000F1B
      [Token(Token = "0x40033AF"), GameParameter.ParameterDesc("ギルドレイドBOSS挑戦中のダメージランキングリストのアイコン")] GUILDRAID_RANKING_DMGBOSS_ICON = 3868, // 0x00000F1C
      [Token(Token = "0x40033B0"), GameParameter.ParameterDesc("ギルドレイドBOSS挑戦中のダメージランキングリストの名前")] GUILDRAID_RANKING_DMGBOSS_NAME = 3869, // 0x00000F1D
      [Token(Token = "0x40033B1"), GameParameter.ParameterDesc("ギルドレイドBOSS挑戦中のダメージランキングリストのレベル")] GUILDRAID_RANKING_DMGBOSS_LEVEL = 3870, // 0x00000F1E
      [Token(Token = "0x40033B2"), GameParameter.ParameterDesc("ギルドレイドBOSS挑戦中のダメージランキングリストのスコア")] GUILDRAID_RANKING_DMGBOSS_SCORE = 3871, // 0x00000F1F
      [Token(Token = "0x40033B3"), GameParameter.ParameterDesc("ギルドレイドBOSS挑戦中のダメージランキングリストの総戦闘力")] GUILDRAID_RANKING_DMGBOSS_POWER = 3872, // 0x00000F20
      [Token(Token = "0x40033B4"), GameParameter.ParameterDesc("ギルドレイドBOSS挑戦中のダメージランキングリストのBOSS名")] GUILDRAID_RANKING_DMGBOSS_BOSSNAME = 3873, // 0x00000F21
      [Token(Token = "0x40033B5"), GameParameter.ParameterDesc("ギルドレイドレポート：周回数")] GUILDRAID_REPORT_ROUND = 3874, // 0x00000F22
      [Token(Token = "0x40033B6"), GameParameter.ParameterDesc("ギルドレイドレポート：与えたダメージ")] GUILDRAID_REPORT_DAMAGE = 3875, // 0x00000F23
      [Token(Token = "0x40033B7"), GameParameter.ParameterDesc("ギルドレイドレポート：挑戦日")] GUILDRAID_REPORT_DATE_DAY = 3876, // 0x00000F24
      [Token(Token = "0x40033B8"), GameParameter.ParameterDesc("ギルドレイド撃破ランキングランク画像")] GUILDRAID_RANKING_BEAT_RANK_IMAGE = 3877, // 0x00000F25
      [Token(Token = "0x40033B9"), GameParameter.ParameterDesc("ギルドレイド撃破ランキングランクテキスト")] GUILDRAID_RANKING_BEAT_RANK_TEXT = 3878, // 0x00000F26
      [Token(Token = "0x40033BA"), GameParameter.ParameterDesc("ギルドレイドレポート：挑戦時間")] GUILDRAID_REPORT_DATE_TIME = 3879, // 0x00000F27
      [Token(Token = "0x40033BB"), GameParameter.ParameterDesc("ギルドレイド模擬戦ボタン")] GUILDRAID_BUTTON_TRIAL = 3880, // 0x00000F28
      [Token(Token = "0x40033BC"), GameParameter.ParameterDesc("ギルドレイドクエスト名")] GUILDRAID_QUEST_NAME = 3881, // 0x00000F29
      [Token(Token = "0x40033BD"), GameParameter.ParameterDesc("ギルドレイドBOSS挑戦中のダメージランキングリストの役職")] GUILDRAID_RANKING_DMGBOSS_ROLE = 3882, // 0x00000F2A
      [Token(Token = "0x40033BE"), GameParameter.ParameterDesc("ギルドレイド挑戦ボタンの挑戦不可ボタン")] GUILDRAID_BUTTON_NOCHALLENGE = 3883, // 0x00000F2B
      [Token(Token = "0x40033BF"), GameParameter.ParameterDesc("ギルドレイドひとつ前のBOSSイメージ")] GUILDRAID_OLDIMAGE = 3884, // 0x00000F2C
      [Token(Token = "0x40033C0"), GameParameter.UsesIndex, GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("レイド編成画面の出撃不可・出撃済みの表示（出撃不可：0、出撃済み：1）")] GUILDRAID_PARTYEDITOR_ENABLE = 3885, // 0x00000F2D
      [Token(Token = "0x40033C1"), GameParameter.ParameterDesc("ギルドレイドBOSS挑戦中のダメージランキングリストの終了ランキング")] GUILDRAID_RANKING_BEAT_RANK_RANKENDTEXT = 3886, // 0x00000F2E
      [Token(Token = "0x40033C2"), GameParameter.ParameterDesc("ギルドレイドBOSS挑戦中のダメージランキングリストランクが単一")] GUILDRAID_RANKING_BEAT_RANK_RANKONLY = 3887, // 0x00000F2F
      [Token(Token = "0x40033C3"), GameParameter.ParameterDesc("ギルドレイドBOSS挑戦中のダメージランキングリストランクが複数")] GUILDRAID_RANKING_BEAT_RANK_RANKMULTI = 3888, // 0x00000F30
      [Token(Token = "0x40033C4"), GameParameter.ParameterDesc("ギルドレイド結果のギルド名")] GUILDRAID_RANKING_REWARD_GUILDNAME = 3889, // 0x00000F31
      [Token(Token = "0x40033C5"), GameParameter.ParameterDesc("ギルドレイド結果のギルドレベル")] GUILDRAID_RANKING_REWARD_GUILDLEVEL = 3890, // 0x00000F32
      [Token(Token = "0x40033C6"), GameParameter.ParameterDesc("ギルドレイド結果のギルドマスター")] GUILDRAID_RANKING_REWARD_MASTER = 3891, // 0x00000F33
      [Token(Token = "0x40033C7"), GameParameter.ParameterDesc("ギルドレイド結果のエンブレム")] GUILDRAID_RANKING_REWARD_EMBLEM = 3892, // 0x00000F34
      [Token(Token = "0x40033C8"), GameParameter.ParameterDesc("ギルドレイド結果のメンバー数")] GUILDRAID_RANKING_REWARD_MEMBER = 3893, // 0x00000F35
      [Token(Token = "0x40033C9"), GameParameter.ParameterDesc("ギルドレイド結果のMAXメンバ数")] GUILDRAID_RANKING_REWARD_MEMBERFULL = 3894, // 0x00000F36
      [Token(Token = "0x40033CA"), GameParameter.ParameterDesc("ギルドレイドの開催時に（ON：0 OFF：1）"), GameParameter.UsesIndex] GUILDRAID_ISPERIOD = 3895, // 0x00000F37
      [Token(Token = "0x40033CB"), GameParameter.ParameterDesc("ギルドレイドの終了日時を表示")] GUILDRAID_PERIOD_TIME = 3896, // 0x00000F38
      [Token(Token = "0x40033CC"), GameParameter.ParameterDesc("ギルドレイドの残りAP回復数")] GUILDRAID_BP_REMAIN_APHEAL = 3897, // 0x00000F39
      [Token(Token = "0x40033CD")] GUILDRAID_ED = 3898, // 0x00000F3A
      [Token(Token = "0x40033CE")] FILTER_ST = 3899, // 0x00000F3B
      [Token(Token = "0x40033CF"), GameParameter.ParameterDesc("レアリティの★表示")] FILTER_TOGGLE_RARITY = 3900, // 0x00000F3C
      [Token(Token = "0x40033D0"), GameParameter.ParameterDesc("名称の表示")] FILTER_TOGGLE_NAME = 3901, // 0x00000F3D
      [Token(Token = "0x40033D1"), GameParameter.ParameterDesc("武具タイプアイコン")] FILTER_TOGGLE_ARTIFACT_TYPE = 3902, // 0x00000F3E
      [Token(Token = "0x40033D2"), GameParameter.ParameterDesc("武具種の表示")] FILTER_ARTIFACT_TYPE_NAME = 3903, // 0x00000F3F
      [Token(Token = "0x40033D3"), GameParameter.ParameterDesc("ルーンのセット効果のアイコン表示")] FILTER_RUNE_SETEFF_ICON = 3904, // 0x00000F40
      [Token(Token = "0x40033D4")] FILTER_ED = 3998, // 0x00000F9E
      [Token(Token = "0x40033D5")] JUKEBOX_ST = 3999, // 0x00000F9F
      [Token(Token = "0x40033D6"), GameParameter.ParameterDesc("ジュークボックス曲名")] JUKEBOX_TITLE = 4000, // 0x00000FA0
      [Token(Token = "0x40033D7"), GameParameter.ParameterDesc("ジュークボックス英語曲名")] JUKEBOX_TITLE_EN = 4001, // 0x00000FA1
      [Token(Token = "0x40033D8"), GameParameter.ParameterDesc("ジュークボックス作詞家")] JUKEBOX_LYRICIST = 4002, // 0x00000FA2
      [Token(Token = "0x40033D9"), GameParameter.ParameterDesc("ジュークボックス作曲者")] JUKEBOX_COMPOSER = 4003, // 0x00000FA3
      [Token(Token = "0x40033DA"), GameParameter.ParameterDesc("ジュークボックスシチュエーション")] JUKEBOX_SITUATION = 4004, // 0x00000FA4
      [Token(Token = "0x40033DB"), GameParameter.ParameterDesc("ジュークボックスセクション名")] JUKEBOX_SECTION = 4005, // 0x00000FA5
      [Token(Token = "0x40033DC")] JUKEBOX_ED = 4098, // 0x00001002
      [Token(Token = "0x40033DD")] GVG_ST = 4099, // 0x00001003
      [Token(Token = "0x40033DE"), GameParameter.ParameterDesc("GvG開催中なら表示(0)/非表示(1)"), GameParameter.UsesIndex] GVG_OPEN = 4100, // 0x00001004
      [Token(Token = "0x40033DF"), GameParameter.ParameterDesc("GvG報酬あるなら表示(0)/非表示(1)"), GameParameter.UsesIndex] GVG_HASREWARD = 4101, // 0x00001005
      [Token(Token = "0x40033E0"), GameParameter.ParameterDesc("GvGの現在有効なルールが存在するか")] GVG_RULE_ISEXIST = 4102, // 0x00001006
      [Token(Token = "0x40033E1"), GameParameter.ParameterDesc("GvGの現在有効なルール(タイトル表示)")] GVG_RULE_NAME = 4103, // 0x00001007
      [Token(Token = "0x40033E2"), GameParameter.ParameterDesc("GvGの終了日時")] GVG_PERIOD_ENDTIME = 4104, // 0x00001008
      [Token(Token = "0x40033E3"), GameParameter.ParameterDesc("GvGの開始日時")] GVG_PERIOD_STARTTIME = 4105, // 0x00001009
      [Token(Token = "0x40033E4"), GameParameter.ParameterDesc("GvGの現在有効なルールにユニット使用可能数が設定されているか")] GVG_RULE_UNITCOUNT_ISEXIST = 4106, // 0x0000100A
      [Token(Token = "0x40033E5"), GameParameter.ParameterDesc("GvGの現在有効なルール(残りユニット使用可能数)")] GVG_RULE_UNITCOUNT_REST = 4107, // 0x0000100B
      [Token(Token = "0x40033E6"), GameParameter.ParameterDesc("GvGの全体期間")] GVG_PERIOD_ALLTIME = 4108, // 0x0000100C
      [Token(Token = "0x40033E7"), GameParameter.UsesIndex, GameParameter.ParameterDesc("GvGのフェーズの切り替え時間(index=0:宣戦開始時間 1:宣戦終了時間 2:攻撃開始時間 3:攻撃終了時間)")] GVG_PHARSE_TIME = 4109, // 0x0000100D
      [Token(Token = "0x40033E8"), GameParameter.ParameterDesc("GvGのPeriodID")] GVG_PERIOD_ID = 4110, // 0x0000100E
      [Token(Token = "0x40033E9"), GameParameter.ParameterDesc("GvGの現在有効なルール(最大ユニット使用可能数)")] GVG_RULE_UNITCOUNT_MAX = 4111, // 0x0000100F
      [Token(Token = "0x40033EA"), GameParameter.UsesIndex, GameParameter.ParameterDesc("イベント同時開催のチェック(index=0:GVGか？ 1:ポートレイドか")] GUILD_EVENT_PRIORITY = 4112, // 0x00001010
      [Token(Token = "0x40033EB"), GameParameter.UsesIndex, GameParameter.ParameterDesc("GvGのフェーズ状態がIndex番号と同じならアクティブ(index=0:宣戦中 1:攻撃中 2:宣戦後クールタイム 3:攻撃後クールタイム 4:期間終了")] GVG_NOW_PHASE = 4113, // 0x00001011
      [Token(Token = "0x40033EC"), GameParameter.ParameterDesc("GvGの1日の宣戦可能最大数")] GVG_DECLARE_COUNT_MAX = 4114, // 0x00001012
      [Token(Token = "0x40033ED"), GameParameter.ParameterDesc("GvGの本日の残り宣戦可能数")] GVG_DECLARE_COUNT_REST = 4115, // 0x00001013
      [Token(Token = "0x40033EE"), GameParameter.ParameterDesc("GvGの防衛最小ユニット数")] GVG_DEFENSE_UNITMIN = 4116, // 0x00001014
      [Token(Token = "0x40033EF"), GameParameter.ParameterDesc("GvGの防衛チーム最大数")] GVG_DEFENSE_TEAMMAX = 4117, // 0x00001015
      [Token(Token = "0x40033F0"), GameParameter.UsesIndex, GameParameter.ParameterDesc("GvGの入口封鎖時間のアクティブ制御(index=0:時間内ならON/index=1:時間外ならtrue")] GVG_EXITTIME_ACTIVE = 4118, // 0x00001016
      [Token(Token = "0x40033F1"), GameParameter.UsesIndex, GameParameter.ParameterDesc("GvGの入口封鎖時間のボタン制御(index=0:時間内ならON/index=1:時間外ならtrue")] GVG_EXITTIME_INTERACTABLE = 4119, // 0x00001017
      [Token(Token = "0x40033F2"), GameParameter.ParameterDesc("GvGのリーグのランク")] GVG_LEAGUE_RANK = 4120, // 0x00001018
      [Token(Token = "0x40033F3"), GameParameter.ParameterDesc("GvGのリーグでのレート")] GVG_LEAGUE_RATE = 4121, // 0x00001019
      [Token(Token = "0x40033F4"), GameParameter.ParameterDesc("GvGのリーグ分けの最低レート")] GVG_LEAGUE_MINRATE = 4122, // 0x0000101A
      [Token(Token = "0x40033F5"), GameParameter.ParameterDesc("GvGのリーグ分けの最大レート")] GVG_LEAGUE_MAXRATE = 4123, // 0x0000101B
      [Token(Token = "0x40033F6"), GameParameter.ParameterDesc("GvGのリーグのアイコン"), GameParameter.AlwaysUpdate] GVG_LEAGUE_ICON = 4124, // 0x0000101C
      [Token(Token = "0x40033F7"), GameParameter.ParameterDesc("GvGのリーグの名称"), GameParameter.AlwaysUpdate] GVG_LEAGUE_NAME = 4125, // 0x0000101D
      [Token(Token = "0x40033F8"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("GvGのリーグの名称(アートフォント版)")] GVG_LEAGUE_NAMEART = 4126, // 0x0000101E
      [Token(Token = "0x40033F9"), GameParameter.ParameterDesc("GvGのリーグのアイコン"), GameParameter.AlwaysUpdate] GVG_LEAGUE_HOMEICON = 4127, // 0x0000101F
      [Token(Token = "0x40033FA"), GameParameter.AlwaysUpdate, GameParameter.UsesIndex, GameParameter.ParameterDesc("GvGのリーグのアイコン表示フラグ")] GVG_LEAGUE_HOMEICONDRAW = 4128, // 0x00001020
      [Token(Token = "0x40033FB"), GameParameter.ParameterDesc("パーティ編成の使用済みユニットが指定されているなら表示"), GameParameter.AlwaysUpdate] GVG_PARTY_UNITUSED = 4129, // 0x00001021
      [Token(Token = "0x40033FC"), GameParameter.AlwaysUpdate, GameParameter.ParameterDesc("パーティ編成の使用済み武具が指定されているなら表示")] GVG_PARTY_ARTIFACTUSED = 4130, // 0x00001022
      [Token(Token = "0x40033FD"), GameParameter.ParameterDesc("パーティ編成の使用済み真理念装が指定されているなら表示"), GameParameter.AlwaysUpdate] GVG_PARTY_CONCEPTCARDUSED = 4131, // 0x00001023
      [Token(Token = "0x40033FE"), GameParameter.ParameterDesc("パーティ編成の使用済みルーンが指定されているなら表示"), GameParameter.AlwaysUpdate] GVG_PARTY_RUNEUSED = 4132, // 0x00001024
      [Token(Token = "0x40033FF")] GVG_ED = 4198, // 0x00001066
      [Token(Token = "0x4003400")] RUNE_ST = 4199, // 0x00001067
      [Token(Token = "0x4003401"), GameParameter.ParameterDesc("レアリティのフレーム表示")] RUNE_RARITY_FRAME = 4200, // 0x00001068
      [Token(Token = "0x4003402"), GameParameter.ParameterDesc("ルーンアイコン表示")] RUNE_ICON = 4201, // 0x00001069
      [Token(Token = "0x4003403"), GameParameter.ParameterDesc("ルーンの所持数")] RUNE_NUM = 4202, // 0x0000106A
      [Token(Token = "0x4003404"), GameParameter.ParameterDesc("ルーンの現在の倉庫サイズ")] RUNE_STORAGE_SIZE = 4203, // 0x0000106B
      [Token(Token = "0x4003405"), GameParameter.ParameterDesc("ルーンのお気に入りアイコン(0:OFF, 1:ON)")] RUNE_FAVORITE_ICON = 4204, // 0x0000106C
      [Token(Token = "0x4003406"), GameParameter.ParameterDesc("ルーンのセット効果アイコン表示")] RUNE_SETEFFECT_ICON = 4205, // 0x0000106D
      [Token(Token = "0x4003407")] RUNE_ED = 4298, // 0x000010CA
      [Token(Token = "0x4003408")] RANKING_ST = 4299, // 0x000010CB
      [Token(Token = "0x4003409"), GameParameter.ParameterDesc("ランクの表示(アートフォント版)"), GameParameter.AlwaysUpdate] RANKING_RANK_IMAGE = 4300, // 0x000010CC
      [Token(Token = "0x400340A"), GameParameter.ParameterDesc("ランクの表示(テキスト版)"), GameParameter.AlwaysUpdate] RANKING_RANK_TEXT = 4301, // 0x000010CD
      [Token(Token = "0x400340B")] RANKING_ED = 4398, // 0x0000112E
      [Token(Token = "0x400340C")] COMBATPOWER_ST = 4399, // 0x0000112F
      [Token(Token = "0x400340D"), GameParameter.ParameterDesc("戦闘力")] COMBATPOWER_VALUE = 4400, // 0x00001130
      [Token(Token = "0x400340E")] COMBATPOWER_ED = 4498, // 0x00001192
      [Token(Token = "0x400340F")] TRUTH_EQUIPMENT_ST = 4499, // 0x00001193
      [Token(Token = "0x4003410"), GameParameter.ParameterDesc("専用装備品を強化可能なら表示が on になる"), GameParameter.AlwaysUpdate] TRUTH_EQUIPMENT_LVUP_BADGE = 4500, // 0x00001194
      [Token(Token = "0x4003411"), GameParameter.ParameterDesc("専用装備品の強化に必要なアイテムの数")] TRUTH_EQUIPMENT_LVUP_NEED_ITEM_NUM = 4501, // 0x00001195
      [Token(Token = "0x4003412"), GameParameter.ParameterDesc("専用装備品の強化に必要なアイテムの所持数")] TRUTH_EQUIPMENT_LVUP_HAVE_ITEM_NUM = 4502, // 0x00001196
      [Token(Token = "0x4003413")] TRUTH_EQUIPMENT_ED = 4598, // 0x000011F6
      [Token(Token = "0x4003414")] ARTIFACT_STONE_ST = 4599, // 0x000011F7
      [Token(Token = "0x4003415"), GameParameter.ParameterDesc("アーティファクトの武輝石変換ポイント")] ARTIFACT_EXCHANGENUM = 4600, // 0x000011F8
      [Token(Token = "0x4003416"), GameParameter.ParameterDesc("アーティファクトの武輝石変換アイテムのアイコン")] ARTIFACT_EXCHANGE_ITEM_ICON = 4601, // 0x000011F9
    }

    [Token(Token = "0x2000F44")]
    public class UsesIndex : Attribute
    {
      [Token(Token = "0x6003FD2")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public UsesIndex()
      {
      }
    }

    [Token(Token = "0x2000F45")]
    public class ParameterDesc : Attribute
    {
      [Token(Token = "0x6003FD3")]
      [Address(RVA = "0x10F04C0", Offset = "0x10EF2C0", VA = "0x110F04C0")]
      public ParameterDesc(string text)
      {
      }
    }

    [Token(Token = "0x2000F46")]
    public class AlwaysUpdate : Attribute
    {
      [Token(Token = "0x6003FD4")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public AlwaysUpdate()
      {
      }
    }

    [Token(Token = "0x2000F47")]
    public class EnumParameterDesc : GameParameter.ParameterDesc
    {
      [Token(Token = "0x6003FD5")]
      [Address(RVA = "0x10F04C0", Offset = "0x10EF2C0", VA = "0x110F04C0")]
      public EnumParameterDesc(string text, System.Type type)
      {
      }
    }

    [Token(Token = "0x2000F48")]
    public class InstanceTypes : Attribute
    {
      [Token(Token = "0x6003FD6")]
      [Address(RVA = "0x10F04C0", Offset = "0x10EF2C0", VA = "0x110F04C0")]
      public InstanceTypes(System.Type instanceType)
      {
      }
    }

    [Token(Token = "0x2000F49")]
    public class ViewTypes : Attribute
    {
      [Token(Token = "0x6003FD7")]
      [Address(RVA = "0x10F04C0", Offset = "0x10EF2C0", VA = "0x110F04C0")]
      public ViewTypes(System.Type viewType)
      {
      }
    }

    [Token(Token = "0x2000F4A")]
    public class SerializeGameObjects : Attribute
    {
      [Token(Token = "0x6003FD8")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public SerializeGameObjects()
      {
      }
    }
  }
}
