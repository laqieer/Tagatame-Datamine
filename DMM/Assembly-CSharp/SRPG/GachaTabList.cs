// Decompiled with JetBrains decompiler
// Type: SRPG.GachaTabList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002451")]
  [AddComponentMenu("UI/GachaTabList")]
  public class GachaTabList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A517")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject TabTemplate;
    [Token(Token = "0x400A518")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject RareTab;
    [Token(Token = "0x400A519")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject NormalTab;
    [Token(Token = "0x400A51A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject ArtifactTab;
    [Token(Token = "0x400A51B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject TicketTab;

    [Token(Token = "0x6009EB4")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009EB5")]
    [Address(RVA = "0x6143A0", Offset = "0x6131A0", VA = "0x106143A0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009EB6")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x6009EB7")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009EB8")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GachaTabList()
    {
    }
  }
}
