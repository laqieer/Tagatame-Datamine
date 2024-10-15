// Decompiled with JetBrains decompiler
// Type: SRPG.WebHelpButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D33")]
  public class WebHelpButton : SRPG_Button
  {
    [Token(Token = "0x400E150")]
    [FieldOffset(Offset = "0xC0")]
    public GameObject Target;
    [Token(Token = "0x400E151")]
    [FieldOffset(Offset = "0xC4")]
    [StringIsResourcePath(typeof (GameObject))]
    public string PrefabPath;
    [Token(Token = "0x400E152")]
    [FieldOffset(Offset = "0xC8")]
    public bool usegAuth;
    [Token(Token = "0x400E153")]
    [FieldOffset(Offset = "0xCC")]
    private IWebHelp mInterface;

    [Token(Token = "0x600D29D")]
    [Address(RVA = "0x9DB8D0", Offset = "0x9DA6D0", VA = "0x109DB8D0", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600D29E")]
    [Address(RVA = "0x9DB780", Offset = "0x9DA580", VA = "0x109DB780", Slot = "5")]
    protected override void OnEnable()
    {
    }

    [Token(Token = "0x600D29F")]
    [Address(RVA = "0x9DB9C0", Offset = "0x9DA7C0", VA = "0x109DB9C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600D2A0")]
    [Address(RVA = "0x9DB800", Offset = "0x9DA600", VA = "0x109DB800")]
    public void ShowWebHelp()
    {
    }

    [Token(Token = "0x600D2A1")]
    [Address(RVA = "0x9DBA30", Offset = "0x9DA830", VA = "0x109DBA30")]
    public WebHelpButton()
    {
    }
  }
}
