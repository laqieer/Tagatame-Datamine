// Decompiled with JetBrains decompiler
// Type: Gsc.App.BootLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Gsc.App
{
  [Token(Token = "0x2003543")]
  public static class BootLoader
  {
    [Token(Token = "0x400FC9A")]
    [FieldOffset(Offset = "0x0")]
    private static AccountManager mAccountManager;

    [Token(Token = "0x170021B0")]
    public static BootLoader.BootState BootStates
    {
      [Token(Token = "0x600EBE5"), Address(RVA = "0xB02070", Offset = "0xB00E70", VA = "0x10B02070")] get
      {
        return new BootLoader.BootState();
      }
      [Token(Token = "0x600EBE6"), Address(RVA = "0xB020B0", Offset = "0xB00EB0", VA = "0x10B020B0")] set
      {
      }
    }

    [Token(Token = "0x600EBE7")]
    [Address(RVA = "0xB01880", Offset = "0xB00680", VA = "0x10B01880")]
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void OnBoot()
    {
    }

    [Token(Token = "0x600EBE8")]
    [Address(RVA = "0xB01600", Offset = "0xB00400", VA = "0x10B01600")]
    public static void GscInit()
    {
    }

    [Token(Token = "0x600EBE9")]
    [Address(RVA = "0xB019A0", Offset = "0xB007A0", VA = "0x10B019A0")]
    public static void Reboot()
    {
    }

    [Token(Token = "0x600EBEA")]
    [Address(RVA = "0xB01BB0", Offset = "0xB009B0", VA = "0x10B01BB0")]
    public static void ResetState()
    {
    }

    [Token(Token = "0x600EBEB")]
    [Address(RVA = "0xB015C0", Offset = "0xB003C0", VA = "0x10B015C0")]
    public static AccountManager GetAccountManager() => (AccountManager) null;

    [Token(Token = "0x600EBEC")]
    [Address(RVA = "0xB01830", Offset = "0xB00630", VA = "0x10B01830")]
    private static IEnumerator InitializeApplication() => (IEnumerator) null;

    [Token(Token = "0x600EBED")]
    [Address(RVA = "0xB02000", Offset = "0xB00E00", VA = "0x10B02000")]
    static BootLoader()
    {
    }

    [Token(Token = "0x2003544")]
    public enum BootState
    {
      [Token(Token = "0x400FC9D")] AWAKE,
      [Token(Token = "0x400FC9E")] SUCCESS,
      [Token(Token = "0x400FC9F")] FAILED,
    }
  }
}
