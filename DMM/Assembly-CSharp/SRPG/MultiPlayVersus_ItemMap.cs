// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayVersus_ItemMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027A3")]
  [AddComponentMenu("UI/MultiPlayVersus_ItemMap")]
  public class MultiPlayVersus_ItemMap : MonoBehaviour
  {
    [Token(Token = "0x400BB49")]
    [FieldOffset(Offset = "0xC")]
    public Text Name;
    [Token(Token = "0x400BB4A")]
    [FieldOffset(Offset = "0x10")]
    public Text Desc;
    [Token(Token = "0x400BB4B")]
    [FieldOffset(Offset = "0x14")]
    public Image Thumnail;

    [Token(Token = "0x600B1F3")]
    [Address(RVA = "0x761760", Offset = "0x760560", VA = "0x10761760")]
    public void UpdateParam(QuestParam param)
    {
    }

    [Token(Token = "0x600B1F4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MultiPlayVersus_ItemMap()
    {
    }
  }
}
