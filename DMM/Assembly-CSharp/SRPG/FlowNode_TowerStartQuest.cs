// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_TowerStartQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200164E")]
  [FlowNode.NodeType("System/Quest/TowerStart", 32741)]
  [FlowNode.Pin(7, "TowerError", FlowNode.PinTypes.Output, 7)]
  [AddComponentMenu("")]
  public class FlowNode_TowerStartQuest : FlowNode_StartQuest
  {
    [Token(Token = "0x4005107")]
    [FieldOffset(Offset = "0x40")]
    private long btlID;

    [Token(Token = "0x6005BA6")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6005BA7")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x6005BA8")]
    [Address(RVA = "0x1310060", Offset = "0x130EE60", VA = "0x11310060", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005BA9")]
    [Address(RVA = "0x1310550", Offset = "0x130F350", VA = "0x11310550", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005BAA")]
    [Address(RVA = "0x130FE40", Offset = "0x130EC40", VA = "0x1130FE40")]
    public bool Error() => new bool();

    [Token(Token = "0x6005BAB")]
    [Address(RVA = "0x1310BA0", Offset = "0x130F9A0", VA = "0x11310BA0")]
    public FlowNode_TowerStartQuest()
    {
    }

    [Token(Token = "0x200164F")]
    private class Json_TowerStartQuest
    {
      [Token(Token = "0x4005108")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;
      [Token(Token = "0x4005109")]
      [FieldOffset(Offset = "0x10")]
      public FlowNode_TowerStartQuest.Json_TowerBtlInfo btlinfo;
      [Token(Token = "0x400510A")]
      [FieldOffset(Offset = "0x14")]
      public int[] missions;
      [Token(Token = "0x400510B")]
      [FieldOffset(Offset = "0x18")]
      public int[] missions_val;
      [Token(Token = "0x400510C")]
      [FieldOffset(Offset = "0x1C")]
      public JSON_TrophyProgress[] guild_trophies;

      [Token(Token = "0x6005BAC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_TowerStartQuest()
      {
      }
    }

    [Token(Token = "0x2001650")]
    private class Json_TowerResume
    {
      [Token(Token = "0x400510D")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;
      [Token(Token = "0x400510E")]
      [FieldOffset(Offset = "0x10")]
      public FlowNode_TowerStartQuest.Json_TowerBtlInfo btlinfo;
      [Token(Token = "0x400510F")]
      [FieldOffset(Offset = "0x14")]
      public int status;
      [Token(Token = "0x4005110")]
      [FieldOffset(Offset = "0x18")]
      public JSON_ReqTowerResuponse.Json_TowerPlayerUnit[] pdeck;
      [Token(Token = "0x4005111")]
      [FieldOffset(Offset = "0x1C")]
      public JSON_ReqTowerResuponse.Json_TowerEnemyUnit[] edeck;
      [Token(Token = "0x4005112")]
      [FieldOffset(Offset = "0x20")]
      public byte round;
      [Token(Token = "0x4005113")]
      [FieldOffset(Offset = "0x24")]
      public int[] missions;
      [Token(Token = "0x4005114")]
      [FieldOffset(Offset = "0x28")]
      public int[] missions_val;

      [Token(Token = "0x6005BAD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_TowerResume()
      {
      }
    }

    [Token(Token = "0x2001651")]
    private class Json_TowerBtlInfo : BattleCore.Json_BtlInfo
    {
      [Token(Token = "0x4005115")]
      [FieldOffset(Offset = "0x98")]
      public int manage_id;
      [Token(Token = "0x4005116")]
      [FieldOffset(Offset = "0x9C")]
      public string tower_iname;
      [Token(Token = "0x4005117")]
      [FieldOffset(Offset = "0xA0")]
      public string floor_iname;

      [Token(Token = "0x6005BAE")]
      [Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0", Slot = "4")]
      public override RandDeckResult[] GetDeck() => (RandDeckResult[]) null;

      [Token(Token = "0x6005BAF")]
      [Address(RVA = "0x13179C0", Offset = "0x13167C0", VA = "0x113179C0", Slot = "5")]
      public override QuestParam GetQuestParam() => (QuestParam) null;

      [Token(Token = "0x6005BB0")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public Json_TowerBtlInfo()
      {
      }
    }
  }
}
