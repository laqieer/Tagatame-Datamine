// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ContentExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003430")]
  public class ContentExhibit : MonoBehaviour
  {
    [Token(Token = "0x400F797")]
    [FieldOffset(Offset = "0xC")]
    [CustomField("コントローラー", CustomFieldAttribute.Type.Component, typeof (ContentController), null)]
    public ContentController mController;
    [Token(Token = "0x400F798")]
    [FieldOffset(Offset = "0x10")]
    [CustomField("フラグ", CustomFieldAttribute.Type.Enum, typeof (ContentExhibit.EKey), typeof (ContentExhibit))]
    public ContentExhibit.EKey mFlag;

    [Token(Token = "0x600E936")]
    public void Render<T>(List<T> models) where T : class
    {
    }

    [Token(Token = "0x600E937")]
    public void Render<T>(List<T> models, Action<ContentNode, T> onAttach) where T : class
    {
    }

    [Token(Token = "0x600E938")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ContentExhibit()
    {
    }

    [Token(Token = "0x2003431")]
    public enum EKey
    {
      [Token(Token = "0x400F79A")] None,
      [Token(Token = "0x400F79B")] ResetScrollPos,
    }
  }
}
