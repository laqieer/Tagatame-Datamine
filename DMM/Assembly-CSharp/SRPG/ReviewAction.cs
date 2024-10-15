// Decompiled with JetBrains decompiler
// Type: SRPG.ReviewAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200294E")]
  [AddComponentMenu("UI/ReviewAction")]
  [FlowNode.Pin(1, "Action", FlowNode.PinTypes.Input, 1)]
  public class ReviewAction : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C708")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    public string url;

    [Token(Token = "0x600BAD5")]
    [Address(RVA = "0x8249D0", Offset = "0x8237D0", VA = "0x108249D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BAD6")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600BAD7")]
    [Address(RVA = "0x824A00", Offset = "0x823800", VA = "0x10824A00")]
    public void OnAction()
    {
    }

    [Token(Token = "0x600BAD8")]
    [Address(RVA = "0x824A30", Offset = "0x823830", VA = "0x10824A30")]
    private void Success()
    {
    }

    [Token(Token = "0x600BAD9")]
    [Address(RVA = "0x824A50", Offset = "0x823850", VA = "0x10824A50")]
    public ReviewAction()
    {
    }
  }
}
