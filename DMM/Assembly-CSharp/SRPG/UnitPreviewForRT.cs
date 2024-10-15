// Decompiled with JetBrains decompiler
// Type: SRPG.UnitPreviewForRT
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
  [Token(Token = "0x2002CE6")]
  [AddComponentMenu("UI/UnitPreviewForRT")]
  public class UnitPreviewForRT : MonoBehaviour
  {
    [Token(Token = "0x400DF3F")]
    [FieldOffset(Offset = "0xC")]
    [Description("3Dユニット投影用テクスチャの描画先")]
    [SerializeField]
    private RawImage m_PreviewImage;
    [Token(Token = "0x400DF40")]
    [FieldOffset(Offset = "0x10")]
    [Description("3Dユニット撮影カメラ")]
    [SerializeField]
    private UnityEngine.Camera m_Camera3D;
    [Token(Token = "0x400DF41")]
    [FieldOffset(Offset = "0x14")]
    [Description("3Dユニット")]
    [SerializeField]
    private UnitPreview m_UnitController;
    [Token(Token = "0x400DF42")]
    [FieldOffset(Offset = "0x18")]
    private RenderTexture m_UnitRenderTexture;

    [Token(Token = "0x600D0F2")]
    [Address(RVA = "0x9BF6B0", Offset = "0x9BE4B0", VA = "0x109BF6B0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600D0F3")]
    [Address(RVA = "0x9BF770", Offset = "0x9BE570", VA = "0x109BF770")]
    private void Start()
    {
    }

    [Token(Token = "0x600D0F4")]
    [Address(RVA = "0x9BF770", Offset = "0x9BE570", VA = "0x109BF770")]
    private void Init()
    {
    }

    [Token(Token = "0x600D0F5")]
    [Address(RVA = "0x9BF770", Offset = "0x9BE570", VA = "0x109BF770")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600D0F6")]
    [Address(RVA = "0x9BF790", Offset = "0x9BE590", VA = "0x109BF790")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600D0F7")]
    [Address(RVA = "0x9BF810", Offset = "0x9BE610", VA = "0x109BF810")]
    public void SetUnitController(UnitPreview controller)
    {
    }

    [Token(Token = "0x600D0F8")]
    [Address(RVA = "0x9BF890", Offset = "0x9BE690", VA = "0x109BF890")]
    private IEnumerator Setup() => (IEnumerator) null;

    [Token(Token = "0x600D0F9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitPreviewForRT()
    {
    }
  }
}
