using Hotel.DataAccess.Repositories.Implementations;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
//Connecting DBContext
var conString = builder.Configuration["ConnectionStrings:default"];
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(conString));
builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

//Adding CORS
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
	options.AddPolicy(name: MyAllowSpecificOrigins,
					  policy =>
					  {
						  policy.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader();
					  });
});
//Adding Fluent Validations
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssemblyContaining<SliderHomeValidator>();

//Adding AppDbContextInitializer
IServiceCollection serviceCollection = builder.Services.AddScoped<AppDbContextInitializer>();

//MailSender Configuration
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.AddTransient<IMailService, MailService>();

//Adding Repository injections
builder.Services.AddScoped<ISliderHomeRepository, SliderHomeRepository>();
builder.Services.AddScoped<IWhyUsRepository, WhyUsRepository>();
builder.Services.AddScoped<INearPlaceRepository, NearPlaceRepository>();
builder.Services.AddScoped<ITeamMemberRepository, TeamMemberRepository>();
builder.Services.AddScoped<ITeamMemberInfoRepository, TeamMemberInfoRepository>();
builder.Services.AddScoped<IServiceOfferRepository, ServiceOfferRepository>();
builder.Services.AddScoped<IServiceImageRepository, ServiceImageRepository>();
builder.Services.AddScoped<IGallaryImageRepository, GallaryImageRepository>();
builder.Services.AddScoped<IGallaryCatagoryRepository, GallaryCatagoryRepository>();
builder.Services.AddScoped<IFlatRepository, FlatRepository>();
builder.Services.AddScoped<IRoomImageRepository, RoomImageRepository>();
builder.Services.AddScoped<IRoomCatagoryRepository, RoomCatagoryRepository>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<IAmentityRepository, AmentityRepository>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<ISentQuestionRepository, SentQuestionRepository>();
builder.Services.AddScoped<IFAQRepository,FAQRepository>();
builder.Services.AddScoped<IUserInfoRepository, UserInfoRepository>();
builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
builder.Services.AddScoped<ISelectedListRepository, SelectedListRepository>();
builder.Services.AddScoped<ISettingTableRepository, SettingsTableRepository>();





//Adding Service Injections
builder.Services.AddScoped<ISliderHomeService, SliderHomeService>();
builder.Services.AddScoped<IWhyUsService, WhyUsService>();
builder.Services.AddScoped<INearPlaceService, NearPlaceService>();
builder.Services.AddScoped<ITeamMemberInfoService, TeamMemberInformationService>();
builder.Services.AddScoped<ITeamMemberService, TeamMemberService>();
builder.Services.AddScoped<IServiceOfferService, ServiceOfferService>();
builder.Services.AddScoped<IServiceImageService, ServiceImageService>();
builder.Services.AddScoped<IGallaryCatagoryService, GallaryCatagoryService>();
builder.Services.AddScoped<IGallaryImageService, GallaryImageService>();
builder.Services.AddScoped<IFlatService, FlatService>();
builder.Services.AddScoped<IRoomImageService, RoomImageService>();
builder.Services.AddScoped<IRoomCatagoryService, RoomCatagoryService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<IAmentityService, AmentityService>();
builder.Services.AddScoped<IAutService, AuthService>();
builder.Services.AddScoped<ITokenCreatorService,TokenCreatorService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<ISentQuestionService, SentQuestionService>();
builder.Services.AddScoped<IFaqService, FaqService>();
builder.Services.AddScoped<IUserInfoService, UserInfoService>();
builder.Services.AddScoped<IReservationService, ReservationService>();
builder.Services.AddScoped<ISelectedListService,SelectedListService>();
builder.Services.AddScoped<ISettingsService, SettingsService>();

//Adding Mapper configuration
builder.Services.AddAutoMapper(typeof(SliderHomeMapper).Assembly);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Adding JWT Configurations
builder.Services.AddAuthentication(option =>
{
	option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
	option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(opt =>
{
	opt.SaveToken = true;
	opt.TokenValidationParameters = new TokenValidationParameters()
	{
		ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
		ValidAudience = builder.Configuration["JwtSettings:Audience"],
		IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:SecurityKey"])),
		LifetimeValidator = (_, expires, _, _) => expires != null ? expires > DateTime.UtcNow : true,

		ValidateIssuer = true,
		ValidateAudience = true,
		ValidateIssuerSigningKey = true,
		ValidateLifetime = true,
		ClockSkew = TimeSpan.Zero,
	};
});
builder.Services.AddAuthorization();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

//AppDBContextInitializer scope using 
using (var scope = app.Services.CreateScope())
{
	var initializer = scope.ServiceProvider.GetRequiredService<AppDbContextInitializer>();
	await initializer.InitializeAsync();
	await initializer.RoleSeedAsync();
	await initializer.UserSeedAsync();
}

app.UseRouting();
app.UseCors(MyAllowSpecificOrigins);
// [EnableCors("MyAllowSpecificOrigins")]
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
