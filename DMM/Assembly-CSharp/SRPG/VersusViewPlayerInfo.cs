// Decompiled with JetBrains decompiler
// Type: SRPG.VersusViewPlayerInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002765")]
  [AddComponentMenu("UI/Multi/Versus/VersusViewPlayerInfo")]
  public class VersusViewPlayerInfo : MonoBehaviour
  {
    [Token(Token = "0x400BA3C")]
    [FieldOffset(Offset = "0xC")]
    public GameObject EmptyObj;
    [Token(Token = "0x400BA3D")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ValidObj;
    [Token(Token = "0x400BA3E")]
    [FieldOffset(Offset = "0x14")]
    public GameObject LeaderUnit;
    [Token(Token = "0x400BA3F")]
    [FieldOffset(Offset = "0x18")]
    public GameObject ReadyObj;
    [Token(Token = "0x400BA40")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject Award;
    [Token(Token = "0x400BA41")]
    [FieldOffset(Offset = "0x20")]
    public Text Name;
    [Token(Token = "0x400BA42")]
    [FieldOffset(Offset = "0x24")]
    public Text Lv;
    [Token(Token = "0x400BA43")]
    [FieldOffset(Offset = "0x28")]
    public Text Total;

    [Token(Token = "0x600B0C7")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B0C8")]
    [Address(RVA = "0x756690", Offset = "0x755490", VA = "0x10756690")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600B0C9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public VersusViewPlayerInfo()
    {
    }
  }
}
