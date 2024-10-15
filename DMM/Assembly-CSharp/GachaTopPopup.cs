// Decompiled with JetBrains decompiler
// Type: GachaTopPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002AC")]
[AddComponentMenu("UI/GachaTopPopup")]
public class GachaTopPopup : MonoBehaviour
{
  [Token(Token = "0x4000B1A")]
  [FieldOffset(Offset = "0xC")]
  public GameObject TextTemplate;
  [Token(Token = "0x4000B1B")]
  [FieldOffset(Offset = "0x10")]
  public GameObject ImageTemplate;
  [Token(Token = "0x4000B1C")]
  [FieldOffset(Offset = "0x14")]
  public GameObject Contents;
  [Token(Token = "0x4000B1D")]
  [FieldOffset(Offset = "0x18")]
  public GameObject Title;
  [Token(Token = "0x4000B1E")]
  [FieldOffset(Offset = "0x0")]
  private static readonly string HOST_URL;
  [Token(Token = "0x4000B1F")]
  [FieldOffset(Offset = "0x4")]
  private static readonly string GACHA_DETAIL_TITLE;
  [Token(Token = "0x4000B20")]
  [FieldOffset(Offset = "0x8")]
  private static readonly string GACHA_DESCRIPTION_TITLE;
  [Token(Token = "0x4000B21")]
  [FieldOffset(Offset = "0x1C")]
  private GachaTopPopup.PopupType popupType;
  [Token(Token = "0x4000B22")]
  [FieldOffset(Offset = "0x20")]
  private GachaTopParam mCurrentGachaTopParam;
  [Token(Token = "0x4000B23")]
  [FieldOffset(Offset = "0x24")]
  private string mCurrentGachaIname;

  [Token(Token = "0x6000E24")]
  [Address(RVA = "0x11D0D80", Offset = "0x11CFB80", VA = "0x111D0D80")]
  private void Start()
  {
  }

  [Token(Token = "0x6000E25")]
  [Address(RVA = "0x11D0AE0", Offset = "0x11CF8E0", VA = "0x111D0AE0")]
  public List<GachaDetailParam> GetGachaDetailData() => (List<GachaDetailParam>) null;

  [Token(Token = "0x6000E26")]
  [Address(RVA = "0x11D06B0", Offset = "0x11CF4B0", VA = "0x111D06B0")]
  private void CreateContents()
  {
  }

  [Token(Token = "0x6000E27")]
  [Address(RVA = "0x11D0D10", Offset = "0x11CFB10", VA = "0x111D0D10")]
  private IEnumerator GetWWWImage(
    GameObject image,
    string url,
    int continue_count = 0,
    int height = 0,
    int width = 0)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000E28")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public GachaTopPopup()
  {
  }

  [Token(Token = "0x6000E29")]
  [Address(RVA = "0x11D1040", Offset = "0x11CFE40", VA = "0x111D1040")]
  static GachaTopPopup()
  {
  }

  [Token(Token = "0x20002AD")]
  public enum PopupType
  {
    [Token(Token = "0x4000B25")] DETAIL,
    [Token(Token = "0x4000B26")] DESCRIPTION,
    [Token(Token = "0x4000B27")] ALL,
  }
}
