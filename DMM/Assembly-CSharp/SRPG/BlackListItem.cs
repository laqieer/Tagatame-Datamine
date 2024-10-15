// Decompiled with JetBrains decompiler
// Type: SRPG.BlackListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200208F")]
  [AddComponentMenu("UI/BlackListItem")]
  public class BlackListItem : MonoBehaviour
  {
    [Token(Token = "0x4008C61")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text Name;
    [Token(Token = "0x4008C62")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text Lv;
    [Token(Token = "0x4008C63")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text LastLogin;
    [Token(Token = "0x4008C64")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RawImage Icon;

    [Token(Token = "0x6008792")]
    [Address(RVA = "0x48E8B0", Offset = "0x48D6B0", VA = "0x1048E8B0")]
    public void Refresh(ChatBlackListParam param)
    {
    }

    [Token(Token = "0x6008793")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BlackListItem()
    {
    }
  }
}
