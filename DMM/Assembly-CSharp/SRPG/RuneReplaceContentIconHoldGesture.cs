// Decompiled with JetBrains decompiler
// Type: SRPG.RuneReplaceContentIconHoldGesture
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029C1")]
  public class RuneReplaceContentIconHoldGesture : 
    MonoBehaviour,
    IPointerDownHandler,
    IEventSystemHandler,
    IHoldGesture
  {
    [Token(Token = "0x400CA8A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RuneReplaceContentNode parent;
    [Token(Token = "0x400CA8B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SystemSound mSound;

    [Token(Token = "0x600BDE8")]
    [Address(RVA = "0x8571A0", Offset = "0x855FA0", VA = "0x108571A0", Slot = "4")]
    public void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600BDE9")]
    [Address(RVA = "0x857200", Offset = "0x856000", VA = "0x10857200", Slot = "5")]
    public void OnPointerHoldStart()
    {
    }

    [Token(Token = "0x600BDEA")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
    public void OnPointerHoldEnd()
    {
    }

    [Token(Token = "0x600BDEB")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneReplaceContentIconHoldGesture()
    {
    }
  }
}
