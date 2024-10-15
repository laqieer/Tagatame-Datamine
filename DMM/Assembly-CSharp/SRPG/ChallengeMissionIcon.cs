// Decompiled with JetBrains decompiler
// Type: SRPG.ChallengeMissionIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200212B")]
  [FlowNode.Pin(0, "更新", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "表示", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "非表示", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "初期化", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(10, "進捗表示", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(20, "進捗非表示", FlowNode.PinTypes.Output, 20)]
  [AddComponentMenu("UI/ChallengeMissionIcon")]
  public class ChallengeMissionIcon : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400901F")]
    [FieldOffset(Offset = "0xC")]
    public GameObject Badge;

    [Token(Token = "0x6008B1F")]
    [Address(RVA = "0x4E96E0", Offset = "0x4E84E0", VA = "0x104E96E0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008B20")]
    [Address(RVA = "0x4E9A60", Offset = "0x4E8860", VA = "0x104E9A60")]
    public void ShowImages(bool value)
    {
    }

    [Token(Token = "0x6008B21")]
    [Address(RVA = "0x4E9870", Offset = "0x4E8670", VA = "0x104E9870")]
    private void Init()
    {
    }

    [Token(Token = "0x6008B22")]
    [Address(RVA = "0x4E9790", Offset = "0x4E8590", VA = "0x104E9790")]
    private IEnumerator AutoOpen() => (IEnumerator) null;

    [Token(Token = "0x6008B23")]
    [Address(RVA = "0x4E9990", Offset = "0x4E8790", VA = "0x104E9990")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008B24")]
    [Address(RVA = "0x4E98F0", Offset = "0x4E86F0", VA = "0x104E98F0")]
    private bool IsNotReceiveRewards(TrophyParam rootTrophy) => new bool();

    [Token(Token = "0x6008B25")]
    [Address(RVA = "0x4E97E0", Offset = "0x4E85E0", VA = "0x104E97E0")]
    private void GetIsComplatedAndIsBadgeActive(ref bool is_complated, ref bool badge)
    {
    }

    [Token(Token = "0x6008B26")]
    [Address(RVA = "0x4E98C0", Offset = "0x4E86C0", VA = "0x104E98C0")]
    private bool IsDispChallengeMissionIcon() => new bool();

    [Token(Token = "0x6008B27")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ChallengeMissionIcon()
    {
    }
  }
}
