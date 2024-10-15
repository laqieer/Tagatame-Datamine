// Decompiled with JetBrains decompiler
// Type: SRPG.GachaResultConceptCardDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002441")]
  [AddComponentMenu("UI/GachaResultConceptCardDetail")]
  public class GachaResultConceptCardDetail : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A446")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Icon;
    [Token(Token = "0x400A447")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text ExprText;
    [Token(Token = "0x400A448")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text FlavorText;
    [Token(Token = "0x400A449")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text NameText;
    [Token(Token = "0x400A44A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ScrollRect ScrollParent;
    [Token(Token = "0x400A44B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform FloavorArea;
    [Token(Token = "0x400A44C")]
    [FieldOffset(Offset = "0x24")]
    private ConceptCardData m_Data;
    [Token(Token = "0x400A44D")]
    [FieldOffset(Offset = "0x28")]
    private float mDecelerationRate;

    [Token(Token = "0x6009E22")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009E23")]
    [Address(RVA = "0x60B570", Offset = "0x60A370", VA = "0x1060B570")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009E24")]
    [Address(RVA = "0x60B880", Offset = "0x60A680", VA = "0x1060B880")]
    public void Setup(ConceptCardData _data)
    {
    }

    [Token(Token = "0x6009E25")]
    [Address(RVA = "0x60B750", Offset = "0x60A550", VA = "0x1060B750")]
    private void ResetScrollPosition()
    {
    }

    [Token(Token = "0x6009E26")]
    [Address(RVA = "0x60B500", Offset = "0x60A300", VA = "0x1060B500")]
    private IEnumerator RefreshScrollRect() => (IEnumerator) null;

    [Token(Token = "0x6009E27")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GachaResultConceptCardDetail()
    {
    }
  }
}
