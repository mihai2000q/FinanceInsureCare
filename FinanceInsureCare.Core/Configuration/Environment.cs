namespace FinanceInsureCare.Core.Configuration;

public static class Environment
{
    public static string DatabaseHost => DotNetEnv.Env.GetString("DATABASE_HOST");
    public static string DatabasePort => DotNetEnv.Env.GetString("DATABASE_PORT");
    public static string DatabaseName => DotNetEnv.Env.GetString("DATABASE_NAME");
    public static string DatabaseUser => DotNetEnv.Env.GetString("DATABASE_USER");
    public static string DatabasePassword => DotNetEnv.Env.GetString("DATABASE_PASSWORD");
}