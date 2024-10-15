// Decompiled with JetBrains decompiler
// Type: SRPG.AreaMapController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E48")]
  [AddComponentMenu("Common/AreaMapController")]
  [RequireComponent(typeof (CanvasGroup))]
  public class AreaMapController : MonoBehaviour
  {
    [Token(Token = "0x4002B6D")]
    [FieldOffset(Offset = "0xC")]
    public string MapID;
    [Token(Token = "0x4002B6E")]
    [FieldOffset(Offset = "0x10")]
    public RawImage_Transparent[] Images;
    [Token(Token = "0x4002B6F")]
    [FieldOffset(Offset = "0x14")]
    public string[] ImageNames;
    [Token(Token = "0x4002B70")]
    [FieldOffset(Offset = "0x18")]
    private CanvasGroup mCanvasGroup;

    [Token(Token = "0x6003AF3")]
    [Address(RVA = "0x7CC4A0", Offset = "0x7CB2A0", VA = "0x107CC4A0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6003AF4")]
    [Address(RVA = "0x10CC8C0", Offset = "0x10CB6C0", VA = "0x110CC8C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6003AF5")]
    [Address(RVA = "0x10CC7D0", Offset = "0x10CB5D0", VA = "0x110CC7D0")]
    public void SetOpacity(float opacity)
    {
    }

    [Token(Token = "0x6003AF6")]
    [Address(RVA = "0x562DB0", Offset = "0x561BB0", VA = "0x10562DB0")]
    private void SetVisible(bool visible)
    {
    }

    [Token(Token = "0x6003AF7")]
    [Address(RVA = "0x10CC680", Offset = "0x10CB480", VA = "0x110CC680")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6003AF8")]
    [Address(RVA = "0x10CC5C0", Offset = "0x10CB3C0", VA = "0x110CC5C0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6003AF9")]
    [Address(RVA = "0x10CC910", Offset = "0x10CB710", VA = "0x110CC910")]
    public AreaMapController()
    {
    }
  }
}
