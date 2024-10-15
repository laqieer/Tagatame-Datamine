// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ExecGacha
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013D8")]
  [AddComponentMenu("")]
  [FlowNode.Pin(6, "ゴールド不足", FlowNode.PinTypes.Output, 6)]
  [FlowNode.Pin(5, "Failed", FlowNode.PinTypes.Output, 5)]
  [FlowNode.Pin(4, "Success", FlowNode.PinTypes.Output, 4)]
  [FlowNode.Pin(30, "VIPガチャ", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(7, "コイン不足", FlowNode.PinTypes.Output, 7)]
  [FlowNode.Pin(20, "レアガチャ", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(11, "ノーマルガチャ10連", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "ノーマルガチャ", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("System/Gacha/ExecGacha", 32741)]
  [FlowNode.Pin(21, "レアガチャ10連", FlowNode.PinTypes.Input, 21)]
  public class FlowNode_ExecGacha : FlowNode_Network
  {
    [Token(Token = "0x4004977")]
    [FieldOffset(Offset = "0x20")]
    public string GachaScene_Normal;
    [Token(Token = "0x4004978")]
    [FieldOffset(Offset = "0x24")]
    public string GachaScene_NormalX;
    [Token(Token = "0x4004979")]
    [FieldOffset(Offset = "0x28")]
    public string GachaScene_Rare;
    [Token(Token = "0x400497A")]
    [FieldOffset(Offset = "0x2C")]
    public string GachaScene_RareX;
    [Token(Token = "0x400497B")]
    [FieldOffset(Offset = "0x30")]
    public string GachaScene_VIP;
    [Token(Token = "0x400497C")]
    [FieldOffset(Offset = "0x34")]
    private GachaOffline mGacha;
    [Token(Token = "0x400497D")]
    [FieldOffset(Offset = "0x38")]
    private FlowNode_ExecGacha.GachaModes mGachaMode;
    [Token(Token = "0x400497E")]
    [FieldOffset(Offset = "0x0")]
    private static readonly int GACHA_GOLD_COST;
    [Token(Token = "0x400497F")]
    [FieldOffset(Offset = "0x4")]
    private static readonly int GACHA_GOLD_MANY_COST;
    [Token(Token = "0x4004980")]
    [FieldOffset(Offset = "0x8")]
    private static readonly int GACHA_COIN_COST;
    [Token(Token = "0x4004981")]
    [FieldOffset(Offset = "0xC")]
    private static readonly int GACHA_COIN_MANY_COST;
    [Token(Token = "0x4004982")]
    [FieldOffset(Offset = "0x3C")]
    private string[] mGachaResult;
    [Token(Token = "0x4004983")]
    [FieldOffset(Offset = "0x40")]
    private bool mGachaResultSet;
    [Token(Token = "0x4004984")]
    [FieldOffset(Offset = "0x44")]
    private GachaScene mGachaScene;

    [Token(Token = "0x600530A")]
    [Address(RVA = "0x127D850", Offset = "0x127C650", VA = "0x1127D850", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600530B")]
    [Address(RVA = "0x127DA70", Offset = "0x127C870", VA = "0x1127DA70")]
    private void OnClickYes(GameObject dialog)
    {
    }

    [Token(Token = "0x600530C")]
    [Address(RVA = "0x127DF00", Offset = "0x127CD00", VA = "0x1127DF00")]
    private void ShowResultDialog(string result)
    {
    }

    [Token(Token = "0x600530D")]
    [Address(RVA = "0x127D130", Offset = "0x127BF30", VA = "0x1127D130")]
    private void ExecNormalGacha()
    {
    }

    [Token(Token = "0x600530E")]
    [Address(RVA = "0x127CF20", Offset = "0x127BD20", VA = "0x1127CF20")]
    private void ExecNormalGachaMany()
    {
    }

    [Token(Token = "0x600530F")]
    [Address(RVA = "0x127D4E0", Offset = "0x127C2E0", VA = "0x1127D4E0")]
    private void ExecRareGacha()
    {
    }

    [Token(Token = "0x6005310")]
    [Address(RVA = "0x127D2F0", Offset = "0x127C0F0", VA = "0x1127D2F0")]
    private void ExecRareGachaMany()
    {
    }

    [Token(Token = "0x6005311")]
    [Address(RVA = "0x127E0C0", Offset = "0x127CEC0", VA = "0x1127E0C0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005312")]
    [Address(RVA = "0x127D6A0", Offset = "0x127C4A0", VA = "0x1127D6A0")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005313")]
    [Address(RVA = "0x127D6C0", Offset = "0x127C4C0", VA = "0x1127D6C0")]
    private string MakeResultString(Json_DropInfo[] drops) => (string) null;

    [Token(Token = "0x6005314")]
    [Address(RVA = "0x127DBC0", Offset = "0x127C9C0", VA = "0x1127DBC0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005315")]
    [Address(RVA = "0x127DEE0", Offset = "0x127CCE0", VA = "0x1127DEE0")]
    private void SetGachaResult(string[] items)
    {
    }

    [Token(Token = "0x6005316")]
    [Address(RVA = "0x127E000", Offset = "0x127CE00", VA = "0x1127E000")]
    private void StartGachaScene(FlowNode_ExecGacha.GachaModes mode)
    {
    }

    [Token(Token = "0x6005317")]
    [Address(RVA = "0x127DF80", Offset = "0x127CD80", VA = "0x1127DF80")]
    private IEnumerator StartGachaSceneAsync(FlowNode_ExecGacha.GachaModes mode)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6005318")]
    [Address(RVA = "0x127DAA0", Offset = "0x127C8A0", VA = "0x1127DAA0")]
    private void OnGachaSceneLoad(GameObject scene)
    {
    }

    [Token(Token = "0x6005319")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ExecGacha()
    {
    }

    [Token(Token = "0x600531A")]
    [Address(RVA = "0x127E0E0", Offset = "0x127CEE0", VA = "0x1127E0E0")]
    static FlowNode_ExecGacha()
    {
    }

    [Token(Token = "0x20013D9")]
    private enum GachaModes
    {
      [Token(Token = "0x4004986")] Normal,
      [Token(Token = "0x4004987")] NormalX,
      [Token(Token = "0x4004988")] Rare,
      [Token(Token = "0x4004989")] RareX,
      [Token(Token = "0x400498A")] VIP,
    }
  }
}
