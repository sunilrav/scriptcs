﻿namespace ScriptCs
{
	public interface IScriptHostFactory
	{
		IScriptHost CreateScriptHost(IScriptPackManager scriptPackManager, string[] scriptArgs);
	}
}
