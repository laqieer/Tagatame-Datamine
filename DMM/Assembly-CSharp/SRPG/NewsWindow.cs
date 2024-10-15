// Decompiled with JetBrains decompiler
// Type: SRPG.NewsWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027BD")]
  [AddComponentMenu("UI/NewsWindow")]
  public class NewsWindow : MonoBehaviour
  {
    [Token(Token = "0x400BC22")]
    [FieldOffset(Offset = "0xC")]
    public RectTransform WebViewContainer;
    [Token(Token = "0x400BC23")]
    [FieldOffset(Offset = "0x10")]
    public bool usegAuth;
    [Token(Token = "0x400BC24")]
    [FieldOffset(Offset = "0x14")]
    public SerializeValueBehaviour ValueList;
    [Token(Token = "0x400BC25")]
    [FieldOffset(Offset = "0x18")]
    private string[] allow_change_scenes;
    [Token(Token = "0x400BC26")]
    [FieldOffset(Offset = "0x1C")]
    public Button CloseButton;

    [Token(Token = "0x600B27A")]
    [Address(RVA = "0x7A8090", Offset = "0x7A6E90", VA = "0x107A8090")]
    private void Start()
    {
    }

    [Token(Token = "0x600B27B")]
    [Address(RVA = "0x7A7F50", Offset = "0x7A6D50", VA = "0x107A7F50")]
    private void StartSceneChange(string new_scene)
    {
    }

    [Token(Token = "0x600B27C")]
    [Address(RVA = "0x7A7E60", Offset = "0x7A6C60", VA = "0x107A7E60")]
    private Rect GetRect() => new Rect();

    [Token(Token = "0x600B27D")]
    [Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x107A8200")]
    public NewsWindow()
    {
    }
  }
}
