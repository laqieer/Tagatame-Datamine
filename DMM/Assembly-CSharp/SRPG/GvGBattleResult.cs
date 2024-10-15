// Decompiled with JetBrains decompiler
// Type: SRPG.GvGBattleResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200259B")]
  [AddComponentMenu("UI/GvG/GvGBattleResult")]
  [FlowNode.Pin(100, "GvGリプレイ", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class GvGBattleResult : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AE6C")]
    public const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400AE6D")]
    public const int PIN_OUTPUT_REPLAY = 100;
    [Token(Token = "0x400AE6E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mPlayerTemplate;
    [Token(Token = "0x400AE6F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mEnemyTemplate;
    [Token(Token = "0x400AE70")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mWin;
    [Token(Token = "0x400AE71")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mLose;

    [Token(Token = "0x600A705")]
    [Address(RVA = "0x68DF70", Offset = "0x68CD70", VA = "0x1068DF70", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A706")]
    [Address(RVA = "0x68DFA0", Offset = "0x68CDA0", VA = "0x1068DFA0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600A707")]
    [Address(RVA = "0x68E3E0", Offset = "0x68D1E0", VA = "0x1068E3E0")]
    public void OnReplaySet()
    {
    }

    [Token(Token = "0x600A708")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GvGBattleResult()
    {
    }
  }
}
