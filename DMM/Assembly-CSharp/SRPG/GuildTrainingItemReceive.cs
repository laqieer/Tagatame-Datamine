// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrainingItemReceive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200253E")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(901, "予期せぬエラー検知", FlowNode.PinTypes.Output, 901)]
  public class GuildTrainingItemReceive : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AAB6")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400AAB7")]
    private const int PIN_OUTPUT_ERROR = 901;
    [Token(Token = "0x400AAB8")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mParent;
    [Token(Token = "0x400AAB9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mContent;

    [Token(Token = "0x600A437")]
    [Address(RVA = "0x661B40", Offset = "0x660940", VA = "0x10661B40")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A438")]
    [Address(RVA = "0x661B20", Offset = "0x660920", VA = "0x10661B20", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A439")]
    [Address(RVA = "0x661B90", Offset = "0x660990", VA = "0x10661B90")]
    private void Initialized()
    {
    }

    [Token(Token = "0x600A43A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildTrainingItemReceive()
    {
    }
  }
}
