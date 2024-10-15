// Decompiled with JetBrains decompiler
// Type: SRPG.ArenaHistoryInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FD7")]
  [AddComponentMenu("UI/ArenaHistoryInfo")]
  public class ArenaHistoryInfo : MonoBehaviour
  {
    [Token(Token = "0x40086FD")]
    [FieldOffset(Offset = "0xC")]
    [Space(10f)]
    public Text Ranking;
    [Token(Token = "0x40086FE")]
    [FieldOffset(Offset = "0x10")]
    public Text created_at;
    [Token(Token = "0x40086FF")]
    [FieldOffset(Offset = "0x14")]
    public Text PlayerName;
    [Token(Token = "0x4008700")]
    [FieldOffset(Offset = "0x18")]
    public Text PlayerLevel;
    [Token(Token = "0x4008701")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject unit_icon;
    [Token(Token = "0x4008702")]
    [FieldOffset(Offset = "0x20")]
    public ImageArray result_image;
    [Token(Token = "0x4008703")]
    [FieldOffset(Offset = "0x24")]
    public ImageArray ranking_delta;
    [Token(Token = "0x4008704")]
    [FieldOffset(Offset = "0x28")]
    public ImageArray history_type;
    [Token(Token = "0x4008705")]
    [FieldOffset(Offset = "0x2C")]
    public Image NewImage;

    [Token(Token = "0x6008323")]
    [Address(RVA = "0x438650", Offset = "0x437450", VA = "0x10438650")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6008324")]
    [Address(RVA = "0x438660", Offset = "0x437460", VA = "0x10438660")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x6008325")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArenaHistoryInfo()
    {
    }
  }
}
