// Decompiled with JetBrains decompiler
// Type: SRPG.QuestDropParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010BF")]
  [AddComponentMenu("Common/QuestDropParam")]
  public class QuestDropParam : MonoBehaviour
  {
    [Token(Token = "0x4003C5E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    public bool IsWarningPopupDisable;
    [Token(Token = "0x4003C5F")]
    [FieldOffset(Offset = "0x0")]
    private static QuestDropParam mQuestDropParam;
    [Token(Token = "0x4003C60")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, SimpleLocalMapsParam> mSimpleLocalMapDict;
    [Token(Token = "0x4003C61")]
    [FieldOffset(Offset = "0x14")]
    private Dictionary<string, EnemyDropList> mSimpleLocalMapsEnemyDropDict;
    [Token(Token = "0x4003C62")]
    [FieldOffset(Offset = "0x18")]
    private List<SimpleDropTableParam> mSimpleDropTables;
    [Token(Token = "0x4003C63")]
    [FieldOffset(Offset = "0x1C")]
    private Dictionary<string, SimpleDropTableList> mSimpleDropTableCacheDict;
    [Token(Token = "0x4003C64")]
    [FieldOffset(Offset = "0x20")]
    private List<SimpleQuestDropParam> mSimpleQuestDrops;
    [Token(Token = "0x4003C65")]
    [FieldOffset(Offset = "0x24")]
    private readonly string MASTER_PATH;
    [Token(Token = "0x4003C66")]
    [FieldOffset(Offset = "0x28")]
    private readonly float LOAD_ASYNC_OWN_TIME_LIMIT;
    [Token(Token = "0x4003C67")]
    [FieldOffset(Offset = "0x2C")]
    private bool mIsLoaded;
    [Token(Token = "0x4003C68")]
    [FieldOffset(Offset = "0x30")]
    private IEnumerator mStartLoadAsyncIEnumerator;

    [Token(Token = "0x17000707")]
    public static QuestDropParam Instance
    {
      [Token(Token = "0x60046D9"), Address(RVA = "0x11E6890", Offset = "0x11E5690", VA = "0x111E6890")] get
      {
        return (QuestDropParam) null;
      }
    }

    [Token(Token = "0x60046DA")]
    [Address(RVA = "0x11E3040", Offset = "0x11E1E40", VA = "0x111E3040")]
    protected void Awake()
    {
    }

    [Token(Token = "0x60046DB")]
    [Address(RVA = "0x11E65F0", Offset = "0x11E53F0", VA = "0x111E65F0")]
    protected void OnDestroy()
    {
    }

    [Token(Token = "0x60046DC")]
    [Address(RVA = "0x11E6080", Offset = "0x11E4E80", VA = "0x111E6080")]
    protected void Start()
    {
    }

    [Token(Token = "0x60046DD")]
    [Address(RVA = "0x11E65D0", Offset = "0x11E53D0", VA = "0x111E65D0")]
    public bool Load() => new bool();

    [Token(Token = "0x60046DE")]
    [Address(RVA = "0x11E6080", Offset = "0x11E4E80", VA = "0x111E6080")]
    private void LoadAsync()
    {
    }

    [Token(Token = "0x60046DF")]
    [Address(RVA = "0x11E60A0", Offset = "0x11E4EA0", VA = "0x111E60A0")]
    private bool LoadJson(string path, bool isAsync) => new bool();

    [Token(Token = "0x60046E0")]
    [Address(RVA = "0x11E31B0", Offset = "0x11E1FB0", VA = "0x111E31B0")]
    public void Deserialize(JSON_QuestDropParam json)
    {
    }

    [Token(Token = "0x60046E1")]
    [Address(RVA = "0x11E3120", Offset = "0x11E1F20", VA = "0x111E3120")]
    private void DeserializeAsync(JSON_QuestDropParam json)
    {
    }

    [Token(Token = "0x60046E2")]
    [Address(RVA = "0x11E6670", Offset = "0x11E5470", VA = "0x111E6670")]
    private IEnumerator StartLoadAsync(JSON_QuestDropParam json) => (IEnumerator) null;

    [Token(Token = "0x60046E3")]
    [Address(RVA = "0x11E4860", Offset = "0x11E3660", VA = "0x111E4860")]
    public ItemParam GetHardDropPiece(string quest_iname, DateTime date_time) => (ItemParam) null;

    [Token(Token = "0x60046E4")]
    [Address(RVA = "0x11E3080", Offset = "0x11E1E80", VA = "0x111E3080")]
    private void CompleteLoading()
    {
    }

    [Token(Token = "0x60046E5")]
    [Address(RVA = "0x11E52A0", Offset = "0x11E40A0", VA = "0x111E52A0")]
    public List<ItemParam> GetQuestDropList(string quest_iname, DateTime date_time)
    {
      return (List<ItemParam>) null;
    }

    [Token(Token = "0x60046E6")]
    [Address(RVA = "0x11E4EB0", Offset = "0x11E3CB0", VA = "0x111E4EB0")]
    public List<BattleCore.DropItemParam> GetQuestDropItemParamList(
      string quest_iname,
      DateTime date_time)
    {
      return (List<BattleCore.DropItemParam>) null;
    }

    [Token(Token = "0x60046E7")]
    [Address(RVA = "0x11E3740", Offset = "0x11E2540", VA = "0x111E3740")]
    public EnemyDropList FindSimpleLocalMaps(string iname) => (EnemyDropList) null;

    [Token(Token = "0x60046E8")]
    [Address(RVA = "0x11E3450", Offset = "0x11E2250", VA = "0x111E3450")]
    public SimpleDropTableList FindSimpleDropTables(string iname) => (SimpleDropTableList) null;

    [Token(Token = "0x60046E9")]
    [Address(RVA = "0x11E5DE0", Offset = "0x11E4BE0", VA = "0x111E5DE0")]
    public bool IsEqualsDropList(string quest_iname, DateTime time1, DateTime time2) => new bool();

    [Token(Token = "0x60046EA")]
    [Address(RVA = "0x11E4750", Offset = "0x11E3550", VA = "0x111E4750")]
    private List<ItemParam> GetEnemyDropItems(string quest_iname, DateTime date_time)
    {
      return (List<ItemParam>) null;
    }

    [Token(Token = "0x60046EB")]
    [Address(RVA = "0x11E40C0", Offset = "0x11E2EC0", VA = "0x111E40C0")]
    private List<ItemParam> GetCurrTimeDropItems(
      List<SimpleDropTableList> drop_tbls,
      DateTime date_time)
    {
      return (List<ItemParam>) null;
    }

    [Token(Token = "0x60046EC")]
    [Address(RVA = "0x11E4640", Offset = "0x11E3440", VA = "0x111E4640")]
    private List<BattleCore.DropItemParam> GetEnemyDropItemParams(
      string quest_iname,
      DateTime date_time)
    {
      return (List<BattleCore.DropItemParam>) null;
    }

    [Token(Token = "0x60046ED")]
    [Address(RVA = "0x11E3920", Offset = "0x11E2720", VA = "0x111E3920")]
    private List<BattleCore.DropItemParam> GetCurrTimeDropItemParams(
      List<SimpleDropTableList> drop_tbls,
      DateTime date_time)
    {
      return (List<BattleCore.DropItemParam>) null;
    }

    [Token(Token = "0x60046EE")]
    [Address(RVA = "0x11E5BB0", Offset = "0x11E49B0", VA = "0x111E5BB0")]
    public bool IsChangedQuestDrops(QuestParam quest) => new bool();

    [Token(Token = "0x60046EF")]
    [Address(RVA = "0x11E49C0", Offset = "0x11E37C0", VA = "0x111E49C0")]
    public List<QuestParam> GetItemDropQuestList(ItemParam item, DateTime date_time)
    {
      return (List<QuestParam>) null;
    }

    [Token(Token = "0x60046F0")]
    [Address(RVA = "0x11E5500", Offset = "0x11E4300", VA = "0x111E5500")]
    public Dictionary<int, Dictionary<byte, List<QuestParam>>> GetRuneDropQuestTable(
      DateTime date_time)
    {
      return (Dictionary<int, Dictionary<byte, List<QuestParam>>>) null;
    }

    [Token(Token = "0x60046F1")]
    [Address(RVA = "0x11E5F40", Offset = "0x11E4D40", VA = "0x111E5F40")]
    private bool IsIgnoreDropQuest(QuestParam quest, ItemParam target, DateTime date_time)
    {
      return new bool();
    }

    [Token(Token = "0x60046F2")]
    [Address(RVA = "0x11E66E0", Offset = "0x11E54E0", VA = "0x111E66E0")]
    public QuestDropParam()
    {
    }
  }
}
