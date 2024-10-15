// Decompiled with JetBrains decompiler
// Type: SRPG.SupportSettingUsedWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B1A")]
  [AddComponentMenu("UI/SupportSettingUsedWindow")]
  public class SupportSettingUsedWindow : MonoBehaviour
  {
    [Token(Token = "0x400D267")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mTemplete;
    [Token(Token = "0x400D268")]
    [FieldOffset(Offset = "0x0")]
    private static SupportSettingUsedWindow mInstance;

    [Token(Token = "0x17001A35")]
    public static SupportSettingUsedWindow Instance
    {
      [Token(Token = "0x600C544"), Address(RVA = "0x8DE480", Offset = "0x8DD280", VA = "0x108DE480")] get
      {
        return (SupportSettingUsedWindow) null;
      }
    }

    [Token(Token = "0x17001A36")]
    public List<SupportUnitUsed> mSupportUsed
    {
      [Token(Token = "0x600C545"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<SupportUnitUsed>) null;
      }
      [Token(Token = "0x600C546"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x600C547")]
    [Address(RVA = "0x8DDDF0", Offset = "0x8DCBF0", VA = "0x108DDDF0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C548")]
    [Address(RVA = "0x8DDE60", Offset = "0x8DCC60", VA = "0x108DDE60")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600C549")]
    [Address(RVA = "0x8DDEA0", Offset = "0x8DCCA0", VA = "0x108DDEA0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C54A")]
    [Address(RVA = "0x8DE000", Offset = "0x8DCE00", VA = "0x108DE000")]
    public void SetupSupportUsed(JSON_SupportHistory[] json)
    {
    }

    [Token(Token = "0x600C54B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public SupportSettingUsedWindow()
    {
    }
  }
}
