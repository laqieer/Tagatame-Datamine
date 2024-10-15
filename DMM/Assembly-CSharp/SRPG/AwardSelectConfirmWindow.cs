// Decompiled with JetBrains decompiler
// Type: SRPG.AwardSelectConfirmWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200207A")]
  [AddComponentMenu("UI/AwardSelectConfirmWindow")]
  public class AwardSelectConfirmWindow : MonoBehaviour
  {
    [Token(Token = "0x4008BF7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject AwardImg;
    [Token(Token = "0x4008BF8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text AwardName;
    [Token(Token = "0x4008BF9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text ExpText;
    [Token(Token = "0x4008BFA")]
    [FieldOffset(Offset = "0x18")]
    private GameManager gm;
    [Token(Token = "0x4008BFB")]
    [FieldOffset(Offset = "0x1C")]
    private ImageArray mImageArray;

    [Token(Token = "0x6008727")]
    [Address(RVA = "0x487060", Offset = "0x485E60", VA = "0x10487060")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008728")]
    [Address(RVA = "0x487510", Offset = "0x486310", VA = "0x10487510")]
    private void Start()
    {
    }

    [Token(Token = "0x6008729")]
    [Address(RVA = "0x487110", Offset = "0x485F10", VA = "0x10487110")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600872A")]
    [Address(RVA = "0x487410", Offset = "0x486210", VA = "0x10487410")]
    private bool SetExtraAwardImage(string bg) => new bool();

    [Token(Token = "0x600872B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AwardSelectConfirmWindow()
    {
    }
  }
}
