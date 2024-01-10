use ScientMgrDb;
SELECT TOP (1000) * FROM [ScientMgrDb].[dbo].[Users]
SELECT TOP (1000) * FROM [ScientMgrDb].[dbo].[Articles]
SELECT TOP (1000) * FROM [ScientMgrDb].[dbo].Researches
SELECT TOP (1000) * FROM [ScientMgrDb].[dbo].UserArticles
SELECT TOP (1000) * FROM [ScientMgrDb].[dbo].UserResearches
SELECT TOP (1000) * FROM [ScientMgrDb].[dbo].[GraduationTopics]

INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Ngô Phương Hòa',1,N'9r9dt3@example.com','5/31/1997',2,N'Thái Bình',N'5274915240');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Trần Phương Hiếu',1,N'j2a96@example.com','6/14/1996',2,N'Hưng Yên',N'9895337302');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Trần Kim An',0,N'jk03l@example.com','1/24/1997',2,N'Ninh Bình',N'5859552674');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Nguyễn Hoàng Hòa',0,N'0132z8@example.com','11/16/1999',2,N'Hải Dương',N'1855965931');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Phạm Phương An',1,N'60jx43@example.com','7/9/1999',2,N'Ninh Bình',N'3333593009');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Nguyễn Đình Anh',1,N'ex1r4fw@example.com','5/1/1997',2,N'Hải Phòng',N'5406982860');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Nguyễn Phương Minh',1,N'z339g@example.com','5/16/2000',0,N'Nam Định',N'1999899889');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Nguyễn Kim An',1,N'o1v4v@example.com','3/3/1998',2,N'Bắc Ninh',N'6585463433');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Lê Hoàng Linh',0,N'037sc4@example.com','7/9/1996',2,N'Hà Nội',N'4265023430');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Huỳnh Đình Thảo',1,N'6y8g38c@example.com','3/30/1996',0,N'Nam Định',N'4775538647');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Ngô Kim An',0,N'39co6@example.com','2/25/1997',2,N'Hà Nội',N'4142279517');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Ngô Kim Giang',0,N'hx456@example.com','5/22/1998',2,N'Bắc Ninh',N'8631493204');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Huỳnh Phương Kim',0,N'0r6n1zr@example.com','3/26/1998',2,N'Vĩnh Phúc',N'5847090274');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Nguyễn Kim Minh',1,N'p0e5876@example.com','1/22/1999',2,N'Bắc Ninh',N'1839611496');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Ngô Kim Hòa',0,N'86d999l@example.com','1/17/1996',2,N'Thái Bình',N'4627862691');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Trần Kim Hòa',0,N'5775x@example.com','4/1/1999',1,N'Hà Nam',N'2552037445');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Nguyễn Kim Tú',0,N'04958@example.com','12/16/1997',2,N'Thái Bình',N'2221156805');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Huỳnh Phương Bình',1,N'621m9@example.com','12/31/1995',0,N'Ninh Bình',N'9971233407');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Mai Đình Hà',1,N'zh243@example.com','1/30/1995',2,N'Vĩnh Phúc',N'7294682262');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Huỳnh Kim Tú',0,N'2a73i5k@example.com','6/26/1998',2,N'Hải Phòng',N'7098551902');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Mai Hoàng Châu',0,N'0uvnj9@example.com','3/20/1997',2,N'Hải Phòng',N'2926680028');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Lê Hoàng Thanh',1,N'nmeh1p@example.com','2/27/1999',1,N'Hà Nam',N'5712856421');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Mai Ngọc Châu',0,N'814ir@example.com','11/23/1995',2,N'Nam Định',N'8264489444');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Đinh Ngọc Bình',0,N'lcmo24@example.com','7/27/1999',2,N'Hải Phòng',N'1917048750');
INSERT INTO Users(Name,Gender,Email,BirthDate,Role,Address,Phone) VALUES (N'Ngô Ngọc Khánh',0,N'k6yqt@example.com','11/29/1995',0,N'Vĩnh Phúc',N'8482987024');

Insert into [ScientMgrDb].[dbo].[Articles] (Title, Keywords, Abstract, SubmisstionAt, SubmissionDate) Values 
	(N'Vietnamese Hate and Offensive Detection using PhoBERT-CNN and Social Media Streaming Data',
	N'xử lý ngôn ngữ tự nhiên, phát hiện ngôn ngữ thù địch, phát hiện ngôn ngữ xúc phạm, PhoBERT, CNN, dữ liệu truyền phát mạng xã hội',
	N'Trong những năm gần đây, nạn ngôn ngữ thù địch và ngôn ngữ xúc phạm trên mạng xã hội ngày càng gia tăng, gây ra những hậu quả nghiêm trọng đối với xã hội. Do đó, việc phát triển các phương pháp phát hiện ngôn ngữ thù địch và ngôn ngữ xúc phạm là rất cần thiết.

Trong bài báo này, chúng tôi đề xuất một phương pháp phát hiện ngôn ngữ thù địch và ngôn ngữ xúc phạm bằng cách sử dụng PhoBERT, một mô hình ngôn ngữ lớn được đào tạo trên tập dữ liệu tiếng Việt. Phương pháp của chúng tôi sử dụng một mô hình CNN để trích xuất các đặc trưng từ văn bản và sau đó sử dụng một mô hình phân loại để phân loại văn bản thành ngôn ngữ thù địch, ngôn ngữ xúc phạm hoặc ngôn ngữ bình thường.

Chúng tôi đánh giá phương pháp của chúng tôi trên một tập dữ liệu tiếng Việt gồm 10.000 mẫu. Kết quả cho thấy phương pháp của chúng tôi có độ chính xác đạt 94% đối với ngôn ngữ thù địch và 92% đối với ngôn ngữ xúc phạm.',
	N'Tạp chí quốc tế Information Processing & Management',
	'2023-07-20');

Insert into [ScientMgrDb].[dbo].[Articles] (Title, Keywords, Abstract, SubmisstionAt, SubmissionDate) Values 
	(N'A Novel Approach for Image Super-Resolution Using Residual Neural Networks and Generative Adversarial Networks',
	N'siêu phân giải hình ảnh, mạng nơ-ron tích lũy, mạng đối nghịch sinh sản',
	N'Siêu phân giải hình ảnh là một kỹ thuật xử lý hình ảnh nhằm nâng cao độ phân giải của một hình ảnh có độ phân giải thấp. Trong những năm gần đây, các phương pháp siêu phân giải hình ảnh sử dụng mạng nơ-ron tích lũy (CNN) và mạng đối nghịch sinh sản (GAN) đã đạt được những thành tựu đáng kể.

Trong bài báo này, chúng tôi đề xuất một phương pháp siêu phân giải hình ảnh mới sử dụng kết hợp CNN và GAN. Phương pháp của chúng tôi sử dụng một mô hình CNN để học các đặc trưng của một hình ảnh có độ phân giải cao, sau đó sử dụng một mô hình GAN để tạo ra một hình ảnh có độ phân giải cao từ một hình ảnh có độ phân giải thấp.

Chúng tôi đánh giá phương pháp của chúng tôi trên một tập dữ liệu hình ảnh gồm 10.000 mẫu. Kết quả cho thấy phương pháp của chúng tôi có chất lượng hình ảnh cao hơn so với các phương pháp sử dụng CNN hoặc GAN đơn lẻ.',
	N'Tạp chí quốc tế Signal Processing: Image Communication',
	'2023-08-20');


Insert into [ScientMgrDb].[dbo].[Articles] (Title, Keywords, Abstract, SubmisstionAt, SubmissionDate) Values 
	(N'An Efficient Power Management Scheme for IoT Devices in Smart Cities',
	N'quản lý năng lượng, thiết bị IoT, thành phố thông minh',
	N'Trong các thành phố thông minh, các thiết bị IoT đóng vai trò quan trọng trong việc thu thập và truyền tải dữ liệu. Tuy nhiên, các thiết bị IoT thường có dung lượng pin nhỏ và thời gian sử dụng pin ngắn. Do đó, việc quản lý năng lượng cho các thiết bị IoT trong các thành phố thông minh là rất cần thiết.

Trong bài báo này, chúng tôi đề xuất một giải pháp quản lý năng lượng hiệu quả cho các thiết bị IoT trong các thành phố thông minh. Giải pháp của chúng tôi sử dụng một thuật toán tối ưu để phân phối nguồn năng lượng cho các thiết bị IoT một cách hợp lý.

Chúng tôi đánh giá giải pháp của chúng tôi trên một mô hình mô phỏng của một thành phố thông minh. Kết quả cho thấy giải pháp của chúng tôi có thể cải thiện thời gian sử dụng pin của các thiết bị IoT lên đến 20%.',
	N'Tạp chí quốc tế IEEE Transactions on Vehicular Technology',
	'2023-09-20');

INSERT INTO [ScientMgrDb].[dbo].[UserArticles] (User_Id, Article_Id) VALUES (7,1);
INSERT INTO [ScientMgrDb].[dbo].[UserArticles] (User_Id, Article_Id) VALUES (2,1);
INSERT INTO [ScientMgrDb].[dbo].[UserArticles] (User_Id, Article_Id) VALUES (3,1);
INSERT INTO [ScientMgrDb].[dbo].[UserArticles] (User_Id, Article_Id) VALUES (4,1);


INSERT INTO [ScientMgrDb].[dbo].[UserArticles] (User_Id, Article_Id) VALUES (10,2);
INSERT INTO [ScientMgrDb].[dbo].[UserArticles] (User_Id, Article_Id) VALUES (1,2);
INSERT INTO [ScientMgrDb].[dbo].[UserArticles] (User_Id, Article_Id) VALUES (9,2);
INSERT INTO [ScientMgrDb].[dbo].[UserArticles] (User_Id, Article_Id) VALUES (8,2);
INSERT INTO [ScientMgrDb].[dbo].[UserArticles] (User_Id, Article_Id) VALUES (11,2);


INSERT INTO [ScientMgrDb].[dbo].[UserArticles] (User_Id, Article_Id) VALUES (18,3);
INSERT INTO [ScientMgrDb].[dbo].[UserArticles] (User_Id, Article_Id) VALUES (16,3);
INSERT INTO [ScientMgrDb].[dbo].[UserArticles] (User_Id, Article_Id) VALUES (22,3);
INSERT INTO [ScientMgrDb].[dbo].[UserArticles] (User_Id, Article_Id) VALUES (23,3);
INSERT INTO [ScientMgrDb].[dbo].[UserArticles] (User_Id, Article_Id) VALUES (24,3);

Insert into [ScientMgrDb].[dbo].[Researches] (Title, Keywords, Description, StartDate, EndDate) VALUES
	(N'Nghiên cứu ứng dụng trí tuệ nhân tạo trong điều trị bệnh ung thư',
	N'trí tuệ nhân tạo, điều trị ung thư, học máy, phân tích hình ảnh, dữ liệu y tế',
	N'Ung thư là một trong những nguyên nhân gây tử vong hàng đầu trên thế giới. Trong những năm gần đây, trí tuệ nhân tạo (AI) đã được ứng dụng thành công trong nhiều lĩnh vực, bao gồm cả điều trị ung thư. AI có thể được sử dụng để phân tích hình ảnh y tế, giúp chẩn đoán bệnh chính xác hơn, cũng như để phát triển các phương pháp điều trị mới hiệu quả hơn.',
	'2023-01-01',
	'2023-12-31');
Insert into [ScientMgrDb].[dbo].[Researches] (Title, Keywords, Description, StartDate, EndDate) VALUES
	(N'Nghiên cứu phát triển hệ thống quản lý kho hàng thông minh',
	N'hệ thống quản lý kho hàng, thông minh, tự động hóa, dữ liệu lớn, IoT',
	N'Quản lý kho hàng là một trong những công việc quan trọng trong chuỗi cung ứng. Trong những năm gần đây, với sự phát triển của công nghệ, các hệ thống quản lý kho hàng thông minh đang được ứng dụng ngày càng rộng rãi. Hệ thống này sử dụng các công nghệ tự động hóa, dữ liệu lớn và IoT để giúp nâng cao hiệu quả quản lý kho hàng.',
	'2023-03-01',
	'2024-08-01');
Insert into [ScientMgrDb].[dbo].[Researches] (Title, Keywords, Description, StartDate, EndDate) VALUES
	(N'Nghiên cứu phát triển ứng dụng giao thông thông minh',
	N'giao thông thông minh, IoT, Big Data, AI, Machine Learning',
	N'Giao thông thông minh là một hệ thống sử dụng các công nghệ tiên tiến để cải thiện hiệu quả và an toàn giao thông. Hệ thống này sử dụng các công nghệ như IoT, Big Data, AI và Machine Learning để thu thập và phân tích dữ liệu giao thông, từ đó đưa ra các giải pháp điều tiết giao thông hiệu quả hơn.',
	'2023-06-01',
	'2024-11-30');

Insert into [ScientMgrDb].[dbo].[Researches] (Title, Keywords, Description, StartDate, EndDate) VALUES
	(N'Nghiên cứu phát triển game thực tế ảo (VR)',
	N'thực tế ảo, game VR, công nghệ VR, thiết bị VR',
	N'Thực tế ảo (VR) là một công nghệ mới đang thu hút được sự quan tâm của nhiều người. VR cho phép người dùng trải nghiệm thế giới ảo một cách chân thực và sống động. Game VR là một ứng dụng phổ biến của VR. Game VR mang đến cho người chơi những trải nghiệm mới lạ và hấp dẫn.',
	'2023-07-01',
	'2024-12-30');
Insert into [ScientMgrDb].[dbo].[Researches] (Title, Keywords, Description, StartDate, EndDate) VALUES
	(N'Nghiên cứu phát triển ứng dụng học trực tuyến',
	N'học trực tuyến, giáo dục trực tuyến, công nghệ giáo dục, e-learning',
	N'Học trực tuyến (e-learning) là một hình thức học tập sử dụng công nghệ thông tin và truyền thông. Học trực tuyến đang ngày càng trở nên phổ biến, đặc biệt là trong bối cảnh đại dịch COVID-19.',
	'2023-02-01',
	'2023-12-30');


INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (25,1);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (5,1);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (6,1);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (7,1);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (8,1);

INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (10,2);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (9,2);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (11,2);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (12,2);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (13,2);

INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (7,3);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (14,3);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (15,3);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (19,3);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (17,3);

INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (18,4);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (20,4);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (22,4);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (23,4);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (21,4);

INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (16,5);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (22,5);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (2,5);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (24,5);
INSERT INTO [ScientMgrDb].[dbo].[UserResearches] (User_Id, Research_Id) VALUES (4,5);


INSERT INTO [ScientMgrDb].[dbo].[GraduationTopics] (Topic, Description, Grade, StudentId, SupervisorId) 
	VALUES (N'Nghiên cứu và phát triển hệ thống quản lý thông tin cho doanh nghiệp',
	N'Hệ thống quản lý thông tin (MIS) là một hệ thống tích hợp các quy trình, kỹ thuật và công cụ nhằm thu thập, lưu trữ, xử lý và phân phối thông tin trong một doanh nghiệp. MIS có vai trò quan trọng trong việc hỗ trợ các hoạt động của doanh nghiệp, từ quản trị, điều hành đến sản xuất kinh doanh.', 
	7.8, 1,7);
	
INSERT INTO [ScientMgrDb].[dbo].[GraduationTopics] (Topic, Description, Grade, StudentId, SupervisorId) 
	VALUES (N'Xây dựng ứng dụng di động cho dịch vụ đặt đồ ăn trực tuyến',
	N'Dịch vụ đặt đồ ăn trực tuyến đang ngày càng phát triển mạnh mẽ, đáp ứng nhu cầu của người tiêu dùng hiện đại. Xây dựng ứng dụng di động cho dịch vụ này là một ý tưởng kinh doanh tiềm năng, mang lại nhiều lợi ích cho doanh nghiệp và người dùng.', 
	8.1, 2,10);

INSERT INTO [ScientMgrDb].[dbo].[GraduationTopics] (Topic, Description, Grade, StudentId, SupervisorId) 
	VALUES (N'Nghiên cứu và phát triển thuật toán tối ưu hóa đường đi trong mạng lưới giao thông',
	N'Thuật toán tối ưu hóa đường đi trong mạng lưới giao thông là một vấn đề quan trọng trong lĩnh vực công nghệ thông tin. Thuật toán này được sử dụng để tìm ra đường đi ngắn nhất, nhanh nhất hoặc tiết kiệm chi phí nhất giữa hai điểm trong mạng lưới giao thông.', 
	7.2, 3,18);

INSERT INTO [ScientMgrDb].[dbo].[GraduationTopics] (Topic, Description, Grade, StudentId, SupervisorId) 
	VALUES (N'Nghiên cứu và phát triển hệ thống nhận dạng giọng nói',
	N'Hệ thống nhận dạng giọng nói là một công nghệ tiên tiến, có nhiều ứng dụng trong cuộc sống. Hệ thống này có thể được sử dụng để điều khiển thiết bị, nhập liệu văn bản hoặc thực hiện các tác vụ khác mà không cần sử dụng bàn phím hoặc chuột.', 
	8.8, 4,25);

INSERT INTO [ScientMgrDb].[dbo].[GraduationTopics] (Topic, Description, Grade, StudentId, SupervisorId) 
	VALUES (N'Xây dựng ứng dụng học trực tuyến cho môn học X',
	N'Học trực tuyến là một hình thức học tập mới, đang ngày càng phổ biến. Ứng dụng học trực tuyến có thể giúp sinh viên học tập hiệu quả hơn, tiết kiệm thời gian và chi phí.', 
	7.5, 5,7);

INSERT INTO [ScientMgrDb].[dbo].[GraduationTopics] (Topic, Description, Grade, StudentId, SupervisorId) 
	VALUES (N'Nghiên cứu và phát triển hệ thống trí tuệ nhân tạo (AI) cho ứng dụng X',
	N'Trí tuệ nhân tạo (AI) là một lĩnh vực công nghệ đang phát triển rất nhanh. AI có thể được ứng dụng trong nhiều lĩnh vực khác nhau, từ sản xuất kinh doanh đến đời sống hàng ngày.', 
	7.9, 6,10);
	
INSERT INTO [ScientMgrDb].[dbo].[GraduationTopics] (Topic, Description, Grade, StudentId, SupervisorId) 
	VALUES (N'Nghiên cứu và phát triển thiết bị điện tử cảm biến môi trường',
	N'Thiết bị điện tử cảm biến môi trường là thiết bị có khả năng thu thập dữ liệu về môi trường. Dữ liệu này có thể được sử dụng để giám sát môi trường, dự báo thời tiết hoặc nghiên cứu khoa học.', 
	9.1, 8,18);

INSERT INTO [ScientMgrDb].[dbo].[GraduationTopics] (Topic, Description, Grade, StudentId, SupervisorId) 
	VALUES (N'Xây dựng hệ thống điều khiển tự động cho robot X',
	N'Robot là một hệ thống máy có thể tự động thực hiện các nhiệm vụ. Hệ thống điều khiển tự động cho robot là một phần quan trọng của robot, giúp robot hoạt động chính xác và hiệu quả.', 
	7.0, 9,25);

INSERT INTO [ScientMgrDb].[dbo].[GraduationTopics] (Topic, Description, Grade, StudentId, SupervisorId) 
	VALUES (N'Nghiên cứu và phát triển năng lượng mặt trời',
	N'Năng lượng mặt trời là một nguồn năng lượng tái tạo, sạch và bền vững. Nghiên cứu và phát triển năng lượng mặt trời là một hướng đi quan trọng trong việc giải quyết vấn đề năng lượng cho tương lai.', 
	8.0, 10,25);

SELECT TOP (1000) * FROM [ScientMgrDb].[dbo].[Users]
SELECT TOP (1000) * FROM [ScientMgrDb].[dbo].[Articles]
SELECT TOP (1000) * FROM [ScientMgrDb].[dbo].Researches
SELECT TOP (1000) * FROM [ScientMgrDb].[dbo].UserArticles
SELECT TOP (1000) * FROM [ScientMgrDb].[dbo].UserResearches
SELECT TOP (1000) * FROM [ScientMgrDb].[dbo].[GraduationTopics]
