// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardDetailImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021EB")]
  [AddComponentMenu("UI/ConceptCardDetailImage")]
  public class ConceptCardDetailImage : MonoBehaviour
  {
    [Token(Token = "0x400952E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RawImage_Transparent Image;
    [Token(Token = "0x400952F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject Message;
    [Token(Token = "0x4009530")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text MessageText;
    [Token(Token = "0x4009531")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject OverlayImageTemplate;

    [Token(Token = "0x6008F59")]
    [Address(RVA = "0x526E30", Offset = "0x525C30", VA = "0x10526E30")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008F5A")]
    [Address(RVA = "0x526F00", Offset = "0x525D00", VA = "0x10526F00")]
    private void Start()
    {
    }

    [Token(Token = "0x6008F5B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardDetailImage()
    {
    }
  }
}
