<style>
	.bg-dashboard{
		background: grey;
	}
</style>

<!-- Begin Page Content -->
<div class="container-fluid">

	<!-- Page Heading -->
	<h1 class="h3 mb-4" style="color: black;">Dashboard</h1>
	<div class="row">
		<div class="col-xl-3 col-md-6 mb-4">
			<div class="card border-left-success shadow h-100 py-2">
				<div class="card-body">
					<div class="row no-gutters align-items-center">
						<div class="col mr-2">
							<div class="text-xs font-weight-bold text-uppercase mb-1" style="color: green;">Jumlah obat  
							</div>
							<div class="h5 mb-0 font-weight-bold text-gray-800"><?php echo($count['obat']); ?></div>
						</div>
						<div class="col-auto">
							<i class="fas fa-medkit fa-2x text-gray-300"></i>
						</div>
					</div>
				</div>
				<a href="obat" class="small-box-footer" style="color: green;">More info <i class="fa fa-arrow-circle-right"></i></a>
			</div>
		</div>
		<div class="col-xl-3 col-md-6 mb-4">
			<div class="card border-left-dark shadow h-100 py-2">
				<div class="card-body">
					<div class="row no-gutters align-items-center">
						<div class="col mr-2">
							<div class="text-xs font-weight-bold text-dark text-uppercase mb-1">Jumlah admin  
							</div>
							<div class="h5 mb-0 font-weight-bold text-gray-800"><?php echo($count['admin']); ?></div>
						</div>
						<div class="col-auto">
							<i class="fas fa-medkit fa-2x text-gray-300"></i>
						</div>
					</div>
				</div>
				<a href="admin" class="small-box-footer" style="color: green;">More info <i class="fa fa-arrow-circle-right"></i></a>
			</div>
		</div>
		<div class="col-xl-3 col-md-6 mb-4">
			<div class="card border-left-info shadow h-100 py-2">
				<div class="card-body">
					<div class="row no-gutters align-items-center">
						<div class="col mr-2">
							<div class="text-xs font-weight-bold text-info text-uppercase mb-1">Jumlah supplier  
							</div>
							<div class="h5 mb-0 font-weight-bold text-gray-800"><?php echo($count['supplier']); ?></div>
						</div>
						<div class="col-auto">
							<i class="fas fa-medkit fa-2x text-gray-300"></i>
						</div>
					</div>
				</div>
				<a href="supplier" class="small-box-footer" style="color: green;">More info <i class="fa fa-arrow-circle-right"></i></a>
			</div>
		</div>
	</div>
</div>
<!-- /.container-fluid -->
