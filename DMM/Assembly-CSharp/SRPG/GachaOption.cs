// Decompiled with JetBrains decompiler
// Type: SRPG.GachaOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200240D")]
  [AddComponentMenu("UI/Gacha/GachaOption")]
  [FlowNode.Pin(1, "Setup", FlowNode.PinTypes.Input, 1)]
  internal class GachaOption : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A2FE")]
    private const int PIN_INPUT = 1;
    [Token(Token = "0x400A2FF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle SkipToggle;
    [Token(Token = "0x400A300")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle AutoDisassemblyRare2Toggle;
    [Token(Token = "0x400A301")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle AutoDisassemblyRare3Toggle;
    [Token(Token = "0x400A302")]
    [FieldOffset(Offset = "0x18")]
    private GachaOptionData OptionData;

    [Token(Token = "0x170015D9")]
    public bool IsSkipToggleOn
    {
      [Token(Token = "0x6009CEF"), Address(RVA = "0x5F8EF0", Offset = "0x5F7CF0", VA = "0x105F8EF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170015DA")]
    public bool IsDisassemblyRare2ToggleOn
    {
      [Token(Token = "0x6009CF0"), Address(RVA = "0x5F8ED0", Offset = "0x5F7CD0", VA = "0x105F8ED0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170015DB")]
    public bool IsDisassemblyRare3ToggleOn
    {
      [Token(Token = "0x6009CF1"), Address(RVA = "0x6026F0", Offset = "0x6014F0", VA = "0x106026F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009CF2")]
    [Address(RVA = "0x6024D0", Offset = "0x6012D0", VA = "0x106024D0", Slot = "4")]
    public void Activated(int pinId)
    {
    }

    [Token(Token = "0x6009CF3")]
    [Address(RVA = "0x6025E0", Offset = "0x6013E0", VA = "0x106025E0")]
    private void SetOptionData()
    {
    }

    [Token(Token = "0x6009CF4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GachaOption()
    {
    }
  }
}
