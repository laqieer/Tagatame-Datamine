// Decompiled with JetBrains decompiler
// Type: SRPG.RuneSlotNumberFilter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029EF")]
  [AddComponentMenu("UI/Rune/RuneSlotNumberFilter")]
  public class RuneSlotNumberFilter : MonoBehaviour
  {
    [Token(Token = "0x400CBC2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RuneManager mRuneManager;
    [Token(Token = "0x400CBC3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ImageArray[] mRuneSlotNumberImg;
    [Token(Token = "0x400CBC4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ImageArray mRuneSlotAllImg;

    [Token(Token = "0x600BF25")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BF26")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BF27")]
    [Address(RVA = "0x866960", Offset = "0x865760", VA = "0x10866960")]
    public void SelectedSlot(RuneSlotIndex slot_index)
    {
    }

    [Token(Token = "0x600BF28")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneSlotNumberFilter()
    {
    }
  }
}
