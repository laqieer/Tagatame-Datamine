// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardCompositeRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021DD")]
  [AddComponentMenu("UI/ConceptCardCompositeRenderer")]
  public class ConceptCardCompositeRenderer : MonoBehaviour
  {
    [Token(Token = "0x40094A8")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RawImage_Transparent Image;
    [Token(Token = "0x40094A9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject Message;
    [Token(Token = "0x40094AA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text MessageText;
    [Token(Token = "0x40094AB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject OverlayImageTemplate;
    [Token(Token = "0x40094AC")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private UnityEngine.Camera Camera;
    [Token(Token = "0x40094AD")]
    [FieldOffset(Offset = "0x20")]
    private RenderTexture mRenderTexture;

    [Token(Token = "0x1700142B")]
    public RenderTexture RenderTexture
    {
      [Token(Token = "0x6008EF2"), Address(RVA = "0x523550", Offset = "0x522350", VA = "0x10523550")] get
      {
        return (RenderTexture) null;
      }
    }

    [Token(Token = "0x6008EF3")]
    [Address(RVA = "0x523430", Offset = "0x522230", VA = "0x10523430")]
    public void Setup(ConceptCardParam param)
    {
    }

    [Token(Token = "0x6008EF4")]
    [Address(RVA = "0x5233C0", Offset = "0x5221C0", VA = "0x105233C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008EF5")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardCompositeRenderer()
    {
    }
  }
}
